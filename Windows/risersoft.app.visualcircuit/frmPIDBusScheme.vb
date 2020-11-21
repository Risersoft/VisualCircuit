Imports Infragistics.Win.UltraWinGrid
Imports risersoft.shared.win
Imports risersoft.shared
Imports risersoft.app.mxform.eto

Public Class frmPIDBusScheme
    Public TerminalRow As UltraGridRow
    Dim myViewBT1, myViewDev As New clsWinView, ds As DataSet
    Friend rBus As DataRow, f As frmPIDSchemePanel

    Private Sub InitForm()
        myViewBT1.SetGrid(Me.UltraGrid4)
        myViewDev.SetGrid(Me.UltraGrid3)
        myView.SetGrid(Me.UltraGrid2)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("CtlBus"))
            myViewBT1.PrepEdit(NewModel.GridViews("BT1"))
            myViewDev.PrepEdit(NewModel.GridViews("Dev"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            f = oview.fParentWin
            strXML = "<PARAMS LOCATION=""" & myUtils.cStrTN(f.PanelCode) & """ PIDCTLBUSID=""" & myUtils.cValTN(rBus("PidCtlBusId")) & """/>"
            Dim objModel As frmPIDBusSchemeModel = Me.InitData("frmPIDBusSchemeModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
                Me.Text = "Assign Wire Bus " & rBus("wirenum")
                Me.SetBT1Filter(Nothing)
                FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Dim dicPIDCtl As New ArrayList, f As frmPIDCtl = New frmPIDCtl
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            myView.mainGrid.myDS.Tables(0).AcceptChanges()
            For Each r1 As DataRow In myView.mainGrid.myDS.Tables(0).Select
                If (myUtils.cValTN(r1("PidCtlBusId")) <> rBus("PidCtlBusId")) AndAlso (Not dicPIDCtl.Contains(r1("PidCtlId"))) Then dicPIDCtl.Add(CInt(r1("PidCtlId")))
                r1("PidCtlBusId") = rBus("PidCtlBusId")
            Next
            If Me.SaveModel() Then
                For Each PidCtlId As Integer In dicPIDCtl.ToArray(GetType(Integer))
                    f.PrepForm(pView, EnumfrmMode.acEditM, PidCtlId)
                    f.reBuildImg(False)
                    f.VSave()
                Next
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub SetBT1Filter(ByVal gRow As UltraGridRow)
        If gRow Is Nothing Then
            myViewBT1.mainGrid.myDv.RowFilter = "0=1"
        Else
            myViewBT1.mainGrid.myDv.RowFilter = "PidCtlId=" & myUtils.cValTN(gRow.Cells("PidCtlId").Value)
        End If
    End Sub

    Private Sub UltraGrid3_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid3.AfterRowActivate
        Me.SetBT1Filter(Me.UltraGrid3.ActiveRow)
    End Sub

    Private Sub btnAssign_Click(sender As System.Object, e As System.EventArgs) Handles btnAssign.Click
        Dim rr(), nr As DataRow
        myViewBT1.ContextRow = myViewBT1.mainGrid.ActiveRow
        If Not myViewBT1.ContextRow Is Nothing Then
            rr = myView.mainGrid.myDS.Tables(0).Select("PidCtlTermId=" & myViewBT1.ContextRow.CellValue("PidCtlTermId"))
            If rr.Length = 0 Then
                nr = myUtils.CopyOneRow(myUtils.DataRowFromGridRow(myViewBT1.ContextRow), myView.mainGrid.myDS.Tables(0))
                nr("WireNum") = rBus("WireNum")
            End If
        End If
    End Sub
End Class








'    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
'        Dim sql, str1 As String, gRow As UltraGridRow

'        If frmMode = EnumfrmMode.acEditM Then
'            sql = "select * from deslistpidunittot() where pidunitid = " & prepIDX
'            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)
'            f = pView.fParentWin

'            Me.Text = "Assign Wire Bus " & rBus("wirenum")
'            myVueDev.mainGrid.myCMain("sortcolsasc") = "ctlcat,legend"
'            myVueDev.MainGrid.QuickConf("select pidctlid, Location, CtlCat, Legend from desListPIDCtl() where pidunitid=" & prepIDX & " and location='" & f.PanelCode & "'", True, "1-1", , "Devices in this Scheme")


'            myVueBT1.mainGrid.myCMain("sortcolsasc") = "legend,terminalname"
'            sql = "select panelcode,pidctlid,location,paneltype,istb,pidctltermid,pidctlbusid,Ctlcat,Legend, TerminalName,WireNum from desListPIDCtlTerm() where pidunitid=" & frmIDX & " and location='" & f.PanelCode & "'"
'            ds = SQLHelper.ExecuteDataset(CommandType.Text, sql)
'            myVueBT1.mainGrid.BindView(ds, , 0)
'            myVueBT1.MainGrid.QuickConf("", True, "1-1-1", , "Wire nos. used by this device")

'            sql = "select panelcode,pidctlid,location,paneltype,istb,pidctltermid,pidctlbusid,Ctlcat,Legend, TerminalName,WireNum from desListPIDCtlTerm() where pidunitid=" & frmIDX & " and location='" & f.PanelCode & "' and pidctlbusid=" & rBus("pidctlbusid")
'            myView.MainGrid.QuickConf(sql, True, "1-1-1", , "Devices using the selected wire bus no.")

'            Me.SetBT1Filter(Nothing)
'            PrepForm = True



'        End If

'    End Function
'    Public Overrides Function VSave() As Boolean
'        Dim dicPIDCtl As New ArrayList, f As frmPIDCtl = New frmPIDCtl

'        Me.InitError()
'        If Me.CanSave Then
'            cm.EndCurrentEdit()
'            myView.mainGrid.myDS.Tables(0).AcceptChanges()
'            For Each r1 As DataRow In myView.mainGrid.myDS.Tables(0).Select
'                If (myUtils.cValTN(r1("pidctlbusid")) <> rBus("pidctlbusid")) AndAlso (Not dicPIDCtl.Contains(r1("pidctlid"))) Then dicPIDCtl.Add(CInt(r1("pidctlid")))
'                r1("pidctlbusid") = rBus("pidctlbusid")
'            Next
'            SQLHelper.SaveResults(myView.mainGrid.myDS.Tables(0), "select pidctltermid,pidctlbusid from pidctlterm where pidctltermid=0")
'            For Each pidctlid As Integer In dicPIDCtl.ToArray(GetType(Integer))
'                f.PrepForm(pView, EnumfrmMode.acEditM, pidctlid)
'                f.reBuildImg(False)
'                f.VSave()
'            Next
'            VSave = True
'        End If
'    End Function

'    Private Sub SetBT1Filter(ByVal gRow As UltraGridRow)
'        If gRow Is Nothing Then
'            myVueBT1.mainGrid.myDV.RowFilter = "0=1"
'        Else
'            myVueBT1.mainGrid.myDV.RowFilter = "pidctlid=" & myUtils.cValTN(gRow.Cells("pidctlid").Value)
'        End If
'    End Sub

'    Private Sub UltraGrid3_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid3.AfterRowActivate
'        Me.SetBT1Filter(Me.UltraGrid3.ActiveRow)
'    End Sub

'    Private Sub btnAssign_Click(sender As System.Object, e As System.EventArgs) Handles btnAssign.Click
'        Dim rr(), nr As DataRow

'        myVueBT1.ContextRow = myVueBT1.mainGrid.ActiveRow
'        If Not myVueBT1.ContextRow Is Nothing Then
'            rr = myView.mainGrid.myDS.Tables(0).Select("pidctltermid=" & myVueBT1.ContextRow.Cells("pidctltermid").Value)
'            If rr.Length = 0 Then
'                nr = myUtils.CopyOneRow(myUtils.DataRowFromGridRow(myVueBT1.ContextRow), myView.mainGrid.myDS.Tables(0))
'                nr("wirenum") = rBus("wirenum")
'            End If
'        End If
'    End Sub
'End Class