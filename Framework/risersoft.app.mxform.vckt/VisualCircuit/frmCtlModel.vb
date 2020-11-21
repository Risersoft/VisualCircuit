Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmCtlModel
    Inherits clsFormDataModel
    Dim myViewTS, myViewMG As clsViewModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Items")
        myViewTS = Me.GetViewModel("TS")
        myViewMG = Me.GetViewModel("MG")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "select distinct CtlMake from ctlItems where CtlMake is not Null order by CtlMake"
        Me.ValueLists.Add("CtlMake", myContext.SQL.VListFromTable(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)))
        Me.AddLookupField("CtlMake", "CtlMake")

        Sql = "Select ItemId, ItemCode, ItemName, UnitName from invListItems() order by ItemName"
        Me.AddLookupField("ItemId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Items").TableName)

        Sql = "Select CtlCatId,CtlCat from CtlCat order by CtlCat"
        Me.AddLookupField("ctlcatid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Cat").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim oRet As clsProcOutput = Me.GetRowLock(prepMode, "CtlItemId", prepIDX)
        If oRet.Success Then

            If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
            sqlForm = "Select * from ctlitems where ctlitemid = " & myUtils.cValTN(prepIDX)
            Me.InitData(sqlForm, "", oView, prepMode, prepIDX, strXML, "ctlitemid", "ctlitem")

            BindDataTable(frmIDX)
            Me.FormPrepared = True
        Else
            Me.AddError("", Nothing, 0, "", "", oRet.Message)
        End If
        Return Me.FormPrepared
    End Function

    Private Sub BindDataTable(ID As Integer)
        myViewTS.MainGrid.BindGridData(GenerateData("ctlterminalset", 0), 0)
        myViewTS.MainGrid.QuickConf("", True, "1")

        myView.MainGrid.BindGridData(GenerateData("ctlitemtermset", ID), 0)
        myView.MainGrid.QuickConf("", True, "3-1")
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""ctlitemtermset"" IDFIELD=""ctlitemtermsetid""><COL KEY=""sortindex""/></BAND>", EnumEditType.acCommandOnly)

        myViewMG.MainGrid.BindGridData(GenerateData("ctlmtg", 0), 0)
        myViewMG.MainGrid.QuickConf("", True, "1-4")
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ctlItem")).Trim.Length = 0 Then Me.AddError("CtlItem", "Enter Item Name")
        If Me.SelectedRow("CtlCatId") Is Nothing Then Me.AddError("CtlCatId", "Enter a Category")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim lastmode As EnumfrmMode = frmMode
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                Me.ChangeModeGetLock("ctlitemid")
                If lastmode = EnumfrmMode.acEditM Then myView.MainGrid.SaveChanges()
                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "ctlmtgmbcp"
                Dim dic As New clsCollecString(Of String)
                dic.Add("CtlMtgMB", "select ctlmtgid,MtgCode + '-' + isnull(Descrip,'') as Mtg from ctlmtg where isnull(mb,0)=1 order by mtgcode")
                dic.Add("CtlMtgCP", "select ctlmtgid,MtgCode + '-' + isnull(Descrip,'') as Mtg from ctlmtg where isnull(cp,0)=1 order by mtgcode")
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            Case "refreshts"
                oRet.Data = GenerateData("ctlterminalset", 0)
            Case "deleterefreshts"
                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "delete from ctlterminalset where ctlterminalsetid=" & myUtils.cValTN(frmIDX))
                oRet.Data = GenerateData("ctlterminalset", 0)
            Case "refreshitem"
                oRet.Data = GenerateData("ctlitemtermset", frmIDX)
            Case "refreshmg"
                oRet.Data = GenerateData("ctlmtg", 0)
            Case "deleterefreshmg"
                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "delete from ctlmtg where ctlmtgid=" & myUtils.cValTN(frmIDX))
                oRet.Data = GenerateData("ctlmtg", 0)
        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "ctlterminalset"
                Dim Sql As String = "select ctlterminalsetid, Descrip from ctlterminalset"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Case "ctlitemtermset"
                Dim Sql As String = "select ctlitemtermsetid,sortindex,ctlitemtermset.ctlterminalsetid,ctlitemtermset.terminalnumxml, Descrip, CtlItemtermset.TerminalNums from ctlitemtermset inner join ctlterminalset on ctlitemtermset.ctlterminalsetid = ctlterminalset.ctlterminalsetid where ctlitemid=" & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Case "ctlmtg"
                Dim Sql As String = "select ctlmtgid, MtgCode, Descrip from ctlmtg"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
        End Select
        Return oRet.Data
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "deleterefreshitem"
                    Dim CtlItemTermSetId As Decimal = myUtils.cValTN(myContext.SQL.ParamValue("@ctlitemtermsetid", Params))
                    Dim CtlItemId As Decimal = myUtils.cValTN(myContext.SQL.ParamValue("@ctlitemid", Params))
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "delete from ctlitemtermset where ctlitemtermsetid=" & CtlItemTermSetId)
                    oRet.Data = GenerateData("ctlitemtermset", CtlItemId)
            End Select
        End If
        Return oRet
    End Function
End Class
