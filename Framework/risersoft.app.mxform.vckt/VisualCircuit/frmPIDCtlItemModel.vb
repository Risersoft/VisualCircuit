Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDCtlItemModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("items")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "Select distinct SubCatId, SubCatName from invListItems() where CharIndex('label',SubCatName)>0 order by SubCatName"
        Me.AddLookupField("SubCat", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "SubCat").TableName)
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        Me.InitData("", "", oView, prepMode, prepIDX, strXML)
        Me.vBag = myContext.Data.VarBag(strXML)
        frmIDX = myUtils.cValTN(Me.vBag("PidCtlId"))

        Dim SubCatID As Integer = Me.dsCombo.Tables("subcat").Rows(0)("subcatid")
        Dim Sql As String = "Select PIDCtlItemID,PIDCtlID,ItemText,Qty,PIDCtlItem.itemid,subcatid,ItemCode,ItemName from PIDCtlItem Inner Join Items on PIDCtlItem.ItemID = Items.ItemID  where PidCtlId=" & frmIDX
        Dim dt1 As DataTable = myFuncsBase.AttributedItemsTable(myContext, Sql, Me.dsCombo.Tables("subcat"), True).Tables(0)

        Dim Sql2 As String = "select itemid,subcatid,ItemCode,ItemName from Items where subcatid= " & SubCatID
        Dim dt2 As DataTable = myFuncsBase.AttributedItemsTable(myContext, Sql2, Nothing, False).Tables(0)


        myView.Mode = EnumViewMode.acSelectM : myView.MultiSelect = True
        myView.MainGrid.BindGridData(dt1.DataSet, 0)


        Dim str1 As String = myAttribBase.ParamWidthString(myContext, myView.MainGrid.myDV.Table.DataSet.Tables("attrib"), "subcatid", SubCatID)

        myView.MainGrid.QuickConf("", True, "1-4" & str1, True)
        myView.MainGrid.MainConf("sqlgrid") = Sql
        myView.MainGrid.MainConf("defaultgroupon") = "lab_labcat"

        myContext.Data.ReverseTick(myView.MainGrid.myDS.Tables(0), dt2, "ItemId", "sysincl")
        myView.MainGrid.MainConf("FORMATXML") = myAttribBase.ParamFormatXML(myContext, myView.MainGrid.myDS.Tables("attrib"))
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""PIDCtlItem"" IDFIELD=""PIDCtlItemID""><COL KEY=""PIDCtlItemID,PIDCtlID,ItemID,ItemText,Qty""/></BAND>", EnumEditType.acCommandAndEdit)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myView.MainGrid.myDS.Tables(0).Select("sysincl=1").Length = 0 Then Me.AddError("", "Select Items")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim lastmode As EnumfrmMode = frmMode
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myUtils.ChangeAll(myView.MainGrid.myDS.Tables(0).Select, "Qty=1")
                myView.MainGrid.SaveChanges(, "PidCtlId=" & frmIDX)
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "items"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("select itemid,subcatid,ItemCode,ItemName from Items where subcatid=@SubCatId order by itemname", Params)
                    oRet.Data = myFuncsBase.AttributedItemsTable(myContext, sql, Nothing, False)
            End Select
        End If
        Return oRet
    End Function
End Class
