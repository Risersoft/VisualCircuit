Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTree
Imports System.Windows.Forms

Public Class frmPIDCtlSelect
    Inherits frmMax
    Public fPC As frmPIDCtl
    Dim RefPrepIDX As Integer

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel)
        myView.SetGrid(Me.UltraGrid1)
        myView.SetTree(Me.UltraTree1)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        RefPrepIDX = myUtils.cValTN(prepIDX)
        Me.MakeTree()
        If frmMode = EnumfrmMode.acEditM Then
            frmIDX = prepIDX
            Me.SelectCtlItem(myUtils.cValTN(frmIDX))
        End If
        If fPC.chkMax.Checked Then Me.WindowState = FormWindowState.Maximized
        PrepForm = True
    End Function

    Private Sub SelectCtlItem(ctlitemid As Integer)
        Dim kRow As DataRow, grow As UltraGridRow
        grow = myWinUtils.FindRow(myView.mainGrid.myGrid, "ctlitemid", ctlitemid, True)
        If Not grow Is Nothing Then myWinUtils.SelectRow(myView.mainGrid.myGrid, grow)
    End Sub

    Public Sub MakeTree(Optional selectednode As String = "root")
        Dim dt1 As DataTable
        Dim r1 As DataRow, dAuto1 As New clsAuto, dAuto2 As New clsAuto


        Dim Model As New clsTreeModel

        Dim xnode = Model.Add("root", "Control Items")
        xnode.Datakey = "listctl"
        xnode.Tag = New clsConf

        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@Old", myUtils.cBoolTN(Me.chkOld.Checked), GetType(Boolean), False))
        Params.Add(New clsSQLParam("@PanelType", myUtils.cValTN(fPC.fp.PanelType), GetType(Integer), False))
        Params.Add(New clsSQLParam("@CtlItemId", myUtils.cValTN(RefPrepIDX), GetType(Integer), False))
        Dim oRet As clsProcOutput = fPC.Model.GenerateParamsOutput("deslistctlitems", Params)
        If oRet.Success Then
            xnode.Tag("strIDXML") = oRet.Description
            dt1 = oRet.Data.Tables(0)
            dAuto1.Init("ctl")
            For Each r1 In dt1.Select
                Dim nodx1 = xnode.Add(xnode.Key & "_" & dAuto1.Val, r1("ctlcat"))
                nodx1.Tag = New clsConf
                nodx1.Tag("strIDXML") = myUtils.cStrTN(xnode.Tag("strIDXML")) & "<FILTER KEY=""ctlcat""><VALUE VALUE1=""" & r1("ctlcat") & """/></FILTER>"
                nodx1.Datakey = xnode.Datakey
            Next
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        myView.myTreeWin.BindModel(Model)
        myView.SelectTree(selectednode, 2, Nothing)
    End Sub

    Public Overrides Function VSave() As Boolean
        Dim gRow As clsWinRow
        Me.InitError()
        gRow = myView.mainGrid.ActiveRow
        If gRow Is Nothing Then WinFormUtils.AddError(myView.mainGrid.myGrid, "Select an item")
        If (Not gRow Is Nothing) AndAlso (Not gRow.Columns.Contains("ctlitemid")) AndAlso (Not gRow.Columns.Contains("item")) Then WinFormUtils.AddError(myView.mainGrid.myGrid, "Select Item")
        If Me.CanSave Then
            myView.ContextRow = gRow
            VSave = True
        Else
            myView.ContextRow = Nothing
        End If
    End Function

    Private Sub chkOld_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOld.CheckedChanged
        Dim gRow As clsWinRow = myView.mainGrid.ActiveRow, ctlitemid As Integer = 0
        If (Not gRow Is Nothing) AndAlso (gRow.Columns.Contains("ctlitemid")) Then ctlitemid = myUtils.cValTN(gRow.CellValue("ctlitemid"))
        Dim onode = myView.myTreeWin.ActiveNode
        If String.IsNullOrEmpty(onode) Then Me.MakeTree() Else Me.MakeTree(onode)
        Me.SelectCtlItem(ctlitemid)
    End Sub
End Class
