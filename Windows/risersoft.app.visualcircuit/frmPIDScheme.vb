Imports risersoft.app.mxform.eto

Public Class frmPIDScheme
    Inherits frmMax
    Dim dicInput As New clsCollecString(Of frmPIDSchemePanel), dicOutput As New clsCollecString(Of frmPIDOutPanel)
    Dim dsScheme As DataSet, fc As New frmPIDOutCable
    Protected Friend myCtl As New clsCtlScheme(Me.Controller)

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim dt1 As DataTable, f1 As frmPIDSchemePanel, f2 As frmPIDOutPanel
        Dim r1, rr(), nr As DataRow
        Me.FormPrepared = False
        Dim objModel As frmPIDSchemeModel = Me.InitData("frmPIDSchemeModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.Text = "Control Scheme for " & myUtils.cStrTN(myRow("PidInfo"))

            dsScheme = Me.Model.DatasetCollection("Scheme")

            dt1 = dsScheme.Tables(1).Copy
            myUtils.MakeDSfromTable(dt1, False)
            For Each r1 In myWinData.SelectDistinct(dsScheme.Tables(0), "location", , , "len(trim(location))>0").Select()
                rr = dt1.Select("panelcode='" & myUtils.cStrTN(r1("location")) & "'")
                If rr.Length = 0 Then
                    nr = myUtils.CopyOneRow(r1, dt1)
                    nr("sortindex") = 100
                    nr("panelcode") = r1("location")
                    nr("PanelName") = r1("location") & " - Panel not found"
                    nr("PanelType") = 4
                End If
            Next

            Me.UltraTabControl2.Tabs.Clear()
            Me.UltraTabControl3.Tabs.Clear()

            For Each r1 In dt1.Select("", "sortindex,pidctlpanelid")
                f1 = New frmPIDSchemePanel
                f1.SetPanel(r1)

                uTab = Me.UltraTabControl2.Tabs.Add(myUtils.cStrTN(r1("panelcode")), f1.PanelName)
                f1.AddtoTab(Me.UltraTabControl2, uTab.Key, True)
                dicInput.Add(r1("panelcode"), f1)
                f1.PrepForm(myView, EnumfrmMode.acEditM, frmIDX)

                If myUtils.IsInList(f1.PanelType, 1, 2) Then
                    f2 = New frmPIDOutPanel
                    f2.SetPanel(r1)
                    uTab = Me.UltraTabControl3.Tabs.Add(myUtils.cStrTN(r1("panelcode")), f2.PanelName)
                    f2.AddtoTab(Me.UltraTabControl3, uTab.Key, True)
                    dicOutput.Add(r1("panelcode"), f2)
                    f2.PrepForm(myView, EnumfrmMode.acEditM, frmIDX)
                End If
            Next


            fc = New frmPIDOutCable
            uTab = Me.UltraTabControl3.Tabs.Add("cable", "Interconnecting Cables")
            fc.AddtoTab(Me.UltraTabControl3, uTab.Key, True)
            fc.PrepForm(myView, EnumfrmMode.acEditM, frmIDX)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        If Me.CanSave Then
            cm.EndCurrentEdit()
            For Each f2 As frmPIDOutPanel In dicOutput.Values
                'Notes
                f2.VSave()
            Next
            VSave = True
        End If
    End Function

    Private Sub reCalc()
        Me.Panel4.Enabled = False
        Me.UltraTabControl1.Enabled = False
        If myWinApp.CheckLicense2() Then
            myCtl.BuildScheme(frmIDX)
            myCtl.MakeLegends(frmIDX)
            For Each f As frmPIDOutPanel In dicOutput.Values
                f.reCalc()
            Next
            fc.reCalc()
        End If
        Me.Panel4.Enabled = True
        Me.UltraTabControl1.Enabled = True
    End Sub

    Private Sub btnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAll.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            Dim oRet As clsProcOutput = Me.GenerateIDOutput("delete", myUtils.cValTN(frmIDX))
            If oRet.Success Then
                Me.PrepForm(pView, frmMode, frmIDX)
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btnEditMultiBus_Click(sender As System.Object, e As System.EventArgs) Handles btnEditMultiBus.Click
        Dim f As New frmPIDMultiBusList
        If f.PrepForm(myView, frmMode, frmIDX) Then f.ShowDialog()
    End Sub

    Private Sub btnResaveMultiBus_Click(sender As System.Object, e As System.EventArgs) Handles btnResCalcMultiBus.Click
        Dim oRet As clsProcOutput = Me.GenerateIDOutput("ctltermbus", myUtils.cValTN(frmIDX))
        If oRet.Success = False Then
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub btnBuild_Click(sender As System.Object, e As System.EventArgs) Handles btnBuild.Click
        Me.reCalc()
    End Sub

    Private Sub btnCopyBus_Click(sender As System.Object, e As System.EventArgs) Handles btnCopyBus.Click
        Dim pidunitid As Integer, gRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        gRow = Me.pView.mainGrid.myGrid.ActiveRow
        If (Not gRow Is Nothing) AndAlso (gRow.Band.Columns.Exists("pidunitid")) Then
            pidunitid = gRow.Cells("pidunitid").Value
            If frmIDX = pidunitid Then
                MsgBox("Please select a different work order", MsgBoxStyle.OkOnly, myWinApp.Vars("appname"))
            Else
                If MsgBox("Copy Bus Nos. and Assignment ?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = vbYes Then
                    Dim oRet As clsProcOutput = Me.GenerateIDOutput("panel", myUtils.cValTN(pidunitid))
                    If oRet.Success Then
                        Dim dsPanel As DataSet = oRet.Data
                        For Each r1 As DataRow In dsPanel.Tables(0).Select
                            Dim rr() As DataRow = dsScheme.Tables(1).Select("panelcode='" & r1("panelsrc") & "'")
                            If rr.Length > 0 Then r1("paneldes") = r1("panelsrc")
                        Next
                        Dim f As New frmGrid
                        f.myView.mainGrid.BindView(dsPanel)
                        f.myView.mainGrid.QuickConf("", True, "1-1", True, "Panel Mapping")
                        f.myView.mainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY=""PanelDes""/></BAND>")
                        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                            Dim Params As New List(Of clsSQLParam)
                            Params.Add(New clsSQLParam("@PidUnitID", frmIDX, GetType(Integer), False))
                            Params.Add(New clsSQLParam("@RefPidUnitID", myUtils.cValTN(pidunitid), GetType(Integer), False))
                            Params.Add(New clsSQLParam("@PanelSrcCSV", myUtils.MakeCSV(dsPanel.Tables(0).Select, "PanelSrc", ",", "", True), GetType(String), True))
                            Params.Add(New clsSQLParam("@PanelDesCSV", myUtils.MakeCSV(dsPanel.Tables(0).Select, "PanelDes", ",", "", True), GetType(String), True))
                            Dim oRet1 As clsProcOutput = Me.GenerateParamsOutput("save", Params)
                            If oRet1.Success Then
                                MsgBox("Wire Nos. and Assignment copied!", MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            Else
                                MsgBox(oRet1.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                            End If
                        End If
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
            End If
        End If
    End Sub
End Class
