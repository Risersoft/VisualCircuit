Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
'fp As frmPIDScheme

Public Class frmPIDOutPanel
    Inherits frmMax
    Friend PanelCode, PanelName As String, PanelType As Integer, rPanel As DataRow
    Dim myViewWD, myViewLug, myViewLbl, myViewHW, myViewMat, myViewBOMR, myViewBOMNR, myViewLeg As New clsWinView
    Dim oWO As clsWOInfoBase

    Friend Sub SetPanel(r1 As DataRow)
        Me.PanelCode = r1("panelcode")
        Me.PanelName = r1("panelname")
        Me.PanelType = r1("paneltype")
        rPanel = r1
        Try
            Me.CtlRTF1.RTFText = myUtils.cStrTN(rPanel("drawingnotetb"))
        Catch ex As Exception
            Try
                Me.CtlRTF1.RTFText = myUtils.cStrTN(rPanel("drawingnotetb"))
            Catch ex2 As Exception
                Me.CtlRTF1.RTFText = ""
            End Try
        End Try
    End Sub

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGrid6)
        myViewWD.SetGrid(Me.UltraGrid1)
        myViewLug.SetGrid(Me.UltraGrid3)
        myViewLbl.SetGrid(Me.UltraGrid9)
        myViewHW.SetGrid(Me.UltraGrid8)
        myViewMat.SetGrid(Me.UltraGrid2)
        myViewBOMR.SetGrid(Me.UltraGrid4)
        myViewBOMNR.SetGrid(Me.UltraGrid5)
        myViewLeg.SetGrid(Me.UltraGrid7)

        Me.CtlRTF1.PrintDocument1.DefaultPageSettings.Margins.Left = 50
        Me.CtlRTF1.PrintDocument1.DefaultPageSettings.Margins.Right = 50
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("TB"))
            myViewWD.PrepEdit(NewModel.GridViews("WD"))
            myViewLug.PrepEdit(NewModel.GridViews("Lug"))
            myViewLbl.PrepEdit(NewModel.GridViews("Lbl"))
            myViewHW.PrepEdit(NewModel.GridViews("HW"))
            myViewMat.PrepEdit(NewModel.GridViews("Mat"))
            myViewBOMR.PrepEdit(NewModel.GridViews("BOMR"))
            myViewBOMNR.PrepEdit(NewModel.GridViews("BOMNR"))
            myViewLeg.PrepEdit(NewModel.GridViews("Leg"))

            Me.cmb_Mode.ValueList = Me.Model.ValueLists("Mode").ComboList
            Me.cmb_Mode.SelectedIndex = 0
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            strXML = "<PARAMS PanelCode=""" & myUtils.cStrTN(PanelCode) & """/>"
            Dim objModel As frmPIDOutPanelModel = Me.InitData("frmPIDOutPanelModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
                Me.Text = "Control Items for " & myRow("pidinfo")
                FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Friend Sub reCalc()
        Me.PrepForm(pView, frmMode, frmIDX)
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        If Me.CanSave Then
            cm.EndCurrentEdit()
            rPanel("drawingnotetb") = Me.CtlRTF1.RTFText
            Dim oRet As clsProcOutput = Me.GenerateDataOutput("save", rPanel.Table.DataSet, 0)
            If oRet.Success = True Then
                VSave = True
            End If
        End If
    End Function

    Private Sub btnTB_Click(sender As System.Object, e As System.EventArgs) Handles btnTB.Click
        Dim r1 As DataRow, ds As New DataSet
        If Me.VSave Then
            r1 = myFormats.rDocu(Me.Controller, frmIDX, "tb", "Terminal Block Diagram", Me.PanelCode, Me.PanelName)
            ds = GenerateDataset("TB")
            If Not IsNothing(ds) Then
                ds.Tables(0).TableName = "tb"
                myFormats.fncTC(myView, "tb", oWO, r1, ds, True, Me.cmb_Mode.Value)
            End If
        End If
    End Sub

    Private Sub btnWD_Click(sender As System.Object, e As System.EventArgs) Handles btnWD.Click
        Dim r1 As DataRow, ds As New DataSet
        If Me.VSave Then
            r1 = myFormats.rDocu(Me.Controller, frmIDX, "wd", "Wiring Diagram", Me.PanelCode, Me.PanelName)
            ds = GenerateDataset("WD")
            If Not IsNothing(ds) Then
                ds.Tables(0).TableName = "wd"
                ds.Tables(1).TableName = "wl"
                myFormats.fncTC(myViewWD, "wd", oWO, r1, ds, True, Me.cmb_Mode.Value)
            End If
        End If
    End Sub

    Private Sub btnML_Click(sender As System.Object, e As System.EventArgs) Handles btnML.Click
        Dim r1 As DataRow, ds As New DataSet, ds2 As DataSet, dt As DataTable, qty As Integer
        If Me.VSave Then
            r1 = myFormats.rDocu(Me.Controller, frmIDX, "ml", "Material List", Me.PanelCode, Me.PanelName)
            ds2 = GenerateDataset("ML")
            If Not IsNothing(ds2) Then
                ds.Tables.Add(ds2.Tables(0).Copy)

                dt = myWinData.SelectDistinct(ds2.Tables(1), "ctlitemid,itemvmsbomid", False)
                myUtils.ChangeAll(dt.Select(), "qty=null")
                For Each r2 As DataRow In dt.Select
                    qty = myUtils.cValTN(ds2.Tables(1).Compute("sum(qty)", myUtils.CombineWhere(False, "ctlitemid=" & myUtils.cValTN(r2("ctlitemid")), "itemvmsbomid=" & myUtils.cValTN(r2("itemvmsbomid")))))
                    If qty > 0 Then r2("qty") = qty
                Next
                ds.Tables.Add(dt.Copy)
                ds.Tables(0).TableName = "deslistmatlist2"
                ds.Tables(1).TableName = "deslistmatlist2BOM"
                myFormats.fncTC(myViewMat, "ml", oWO, r1, ds, False, Me.cmb_Mode.Value)
            End If
        End If
    End Sub

    Private Sub btnLHPanel_Click(sender As System.Object, e As System.EventArgs) Handles btnLHPanel.Click
        Dim r1 As DataRow, ds As New DataSet
        If Me.VSave Then
            r1 = myFormats.rDocu(Me.Controller, frmIDX, "lh", "Labels, Hardware and Lugs", Me.PanelCode, Me.PanelName)
            ds = GenerateDataset("LHPANEL")
            If Not IsNothing(ds) Then
                ds.Tables(0).TableName = "lbl"
                ds.Tables(1).TableName = "hw"
                ds.Tables(2).TableName = "lug"
                myFormats.fncTC(myViewWD, "lh", oWO, r1, ds, True, Me.cmb_Mode.Value)
            End If
        End If
    End Sub

    Private Sub btnLHPIDU_Click(sender As System.Object, e As System.EventArgs) Handles btnLHPIDU.Click
        Dim r1 As DataRow, ds As New DataSet
        If Me.VSave Then
            r1 = myFormats.rDocu(Me.Controller, frmIDX, "lh", "Labels, Hardware and Lugs", "", "")
            ds = GenerateDataset("LHPIDU")
            If Not IsNothing(ds) Then
                ds.Tables(0).TableName = "lbl"
                ds.Tables(1).TableName = "hw"
                ds.Tables(2).TableName = "lug"
                myFormats.fncTC(myViewWD, "lh", oWO, r1, ds, True, Me.cmb_Mode.Value)
            End If
        End If
    End Sub

    Private Function GenerateDataset(Key As String) As DataSet
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Params.Add(New clsSQLParam("@PanelCode", "'" & myUtils.cStrTN(PanelCode) & "'", GetType(String), False))
        Dim oRet As clsProcOutput = Me.GenerateParamsOutput(Key.Trim.ToUpper, Params)
        If oRet.Success Then
            Return oRet.Data
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Function
End Class
