Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization
Imports risersoft.shared.dotnetfx

<DataContract>
Public Class frmPIDCtlModel
    Inherits clsFormDataModel
    Dim myViewLabItem, myViewLabText As clsViewModel
    Dim myFuncsVC As New clsFuncsVC(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("CtlTerm")
        myViewLabItem = Me.GetViewModel("LabItem")
        myViewLabText = Me.GetViewModel("LabText")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "select ctlitemid,item,ctlcat,itemcode,make,spec,suppspec,mtgmbid,mtgcpid,istb,haswd,isold from desListCtlItems()"
        Me.AddLookupField("CtlItemID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Items").TableName)

        Me.DatasetCollection.Add("DsTs", myFuncsVC.dsTS)

        Me.ValueLists.Add("dicSetType", myContext.SQL.VListFromDic(myFuncsVC.dicSetType))

        Dim ds As DataSet = myFuncsVC.MountingDataSet(False)
        Me.AddLookupField("MtgID", myUtils.AddTable(Me.dsCombo, ds, "Mtg").TableName)

        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "Select * from pidctl where pidctlid = " & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "Location,PidUnitId", oView, prepMode, prepIDX, strXML, "pidctlid", "Legend")

        Dim Sql As String = "select distinct GaUse from PidCtl where len(GaUse)>0  and PidUnitId=" & myUtils.cValTN(myRow("PidUnitId")) & " order by GaUse"
        Me.ValueLists.Add("GaUse", myContext.SQL.VListFromTable(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)))
        Me.AddLookupField("GaUse", "GaUse")

        myViewLabItem.MainGrid.BindGridData(GenerateData("pidctlitem", frmIDX), 0)
        myViewLabItem.MainGrid.QuickConf("", True, "1-5-1")


        myView.MainGrid.MainConf("showrownumber") = True
        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""settypecode"" CAPTION=""Type""/>"
        myView.MainGrid.MainConf("sortcolsasc") = "sortindexctl"
        myView.MainGrid.MainConf("bansort") = True
        myView.MainGrid.BindGridData(GenerateData("pidctlterm", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "1-1-1-1")
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""pidctlterm"" IDFIELD=""pidctltermid""><COL KEY=""sortindexctl,sortindexwire,pidctlid, ctlitemtermsetid,TerminalName,pidctlbusID,pidctltermid2""/></BAND>", EnumEditType.acCommandOnly)


        Sql = "select pidctlitemid,pidctlid,ItemText, Qty from pidctlitem where pidctlid=%frmidx% and itemid is null"
        myViewLabText.MainGrid.QuickConf(Sql, True, "5-1")
        myViewLabText.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""PIDCTLITEMID"" TABLE=""PIDCTLITEM""><COL KEY=""pidctlid,itemtext,qty""/></BAND>", EnumEditType.acCommandAndEdit)
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.NullNot(myRow("CtlItemID")) Then Me.AddError("CtlItemID", "Select Item")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim lastmode As EnumfrmMode = frmMode
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("PidCtlId")
                frmMode = EnumfrmMode.acEditM
                myView.MainGrid.SaveChanges(, "PidCtlId=" & frmIDX)
                myViewLabText.MainGrid.SaveChanges(, "PidCtlId=" & frmIDX)
                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim strFilter1, str1 As String, strFilter2 As String = ""
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "deslistctlitems"
                    Dim Old As Boolean = myContext.SQL.ParamValue("@Old", Params)
                    Dim PanelType As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PanelType", Params))
                    Dim CtlItemId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@CtlItemId", Params))

                    strFilter2 = "ctlitemid=" & myUtils.cValTN(CtlItemId)

                    If Old Then strFilter1 = "0=0" Else strFilter1 = "isnull(isold,0)=0"
                    strFilter1 = myUtils.CombineWhereOR(False, strFilter1, strFilter2)

                    Select Case PanelType
                        Case 3
                            str1 = "ctlcat='Terminal Block'"
                        Case 4
                            str1 = myUtils.CombineWhereOR(False, "isnull(Loc,'')='tf'", "ctlcat='Terminal Block'")
                        Case Else
                            str1 = "isnull(Loc,'')<>'tf'"
                    End Select
                    oRet.Description = "<MODROWCOMPLEX><MODROW VIEWKEY='listctl'><SQLWHERE2>" & myUtils.CombineWhere(False, XMLUtils.ReplaceSpecialChars(str1), strFilter1) & "</SQLWHERE2></MODROW></MODROWCOMPLEX>"
                    Dim sql As String = "select distinct ctlcat from deslistctlitems() where " & str1 & " order by ctlcat"
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
                Case "deleterefresh"
                    Dim PidCtlId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidctlid", Params))
                    Dim PidCtlItemId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidctlitemid", Params))
                    Dim sql As String = "Delete from PidCtlItem where PidCtlItemId =" & myUtils.cValTN(PidCtlItemId)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    oRet.Data = GenerateData("pidctlitem", PidCtlId)
                Case "refresh"
                    Dim PidCtlId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidctlid", Params))
                    oRet.Data = GenerateData("pidctlitem", PidCtlId)
            End Select
        End If
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "pidctlitem"
                Dim Sql As String = "select pidctlitemid,pidctlid,items.ItemID,Items.ItemCode, Items.Itemname, Qty from pidctlitem inner join items on pidctlitem.itemid = items.itemid where pidctlid= " & ID & " and items.itemid is not null"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Case "pidctlterm"
                Dim Sql As String = "select pidctltermid,pidctltermid2,convert(bit,0) as incl,sortindexctl as sortindex,sortindexwire,pidctlterm.pidctlbusID,pidctlid,ctlitemtermset.ctlterminalsetid, pidctlterm.ctlitemtermsetid,SortIndexCtl,CtlTerminalSet.SetTypeCode,TerminalName,WireNum from PIDCtlTerm left join ctlitemtermset on pidctlterm.ctlitemtermsetid = ctlitemtermset.ctlitemtermsetid left join pidctlbus on pidctlterm.pidctlbusid = pidctlbus.pidctlbusid left join ctlterminalset on ctlitemtermset.ctlterminalsetid = ctlterminalset.ctlterminalsetid where pidctlid= " & myUtils.cValTN(ID) & " order by ctlitemtermsetid,sortindexctl"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
        End Select
        Return oRet.Data
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "pidctlterm"
                oRet.Data = GenerateData("pidctlterm", myUtils.cValTN(frmIDX))
        End Select
        Return oRet
    End Function
End Class