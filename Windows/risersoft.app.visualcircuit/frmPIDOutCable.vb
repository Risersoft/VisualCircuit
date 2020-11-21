Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
Imports risersoft.shared.Extensions
Imports risersoft.app.mxent

Public Class frmPIDOutCable
    Inherits frmMax
    Dim myViewCab2 As New clsWinView, oWO As clsWOInfoBase

    Private Sub InitForm()
        myView.SetGrid(UltraGrid4)
        myViewCab2.SetGrid(Me.UltraGrid5)
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        Me.cmb_Mode.ValueList = NewModel.ValueLists("Mode").ComboList
        Me.cmb_Mode.SelectedIndex = 0
        Return True
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            oWO = myPIDU.GenerateWOInfo(Me.Controller, prepIDX)
            If Me.InitData(oWO.rPIDU, oView, prepIDX) Then
                Me.Text = "Control Items for " & myUtils.cStrTN(myRow("PidInfo"))
                Me.BindModel(pView.fParent.Model)
                Me.reCalc()
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If Me.CanSave Then
            cm.EndCurrentEdit()
            VSave = True
        End If
    End Function

    Friend Sub reCalc()
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PidUnitID", frmIDX, GetType(Integer), False))
        Dim Model1 As clsViewModel = pView.fParentWin.GenerateParamsModel("pidctlcable", Params)
        myView.BindView(Model1)

        Dim Model2 As clsViewModel = pView.fParentWin.GenerateParamsModel("pidcable", Params)
        myViewCab2.BindView(Model2)
    End Sub

    Private Sub UltraGrid4_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid4.AfterRowActivate
        Dim str1, str2 As String
        If Me.FormPrepared Then
            myView.ContextRow = myView.mainGrid.ActiveRow
            str1 = "loc1='" & myUtils.cStrTN(myView.ContextRow.CellValue("loc1")) & "'"
            str2 = "loc2='" & myUtils.cStrTN(myView.ContextRow.CellValue("loc2")) & "'"
            myViewCab2.mainGrid.myDv.RowFilter = myUtils.CombineWhere(False, str1, str2)
            myWinUtils.SelectRow(myViewCab2.mainGrid.myGrid)
        End If
    End Sub

    Private Sub btnIC_Click(sender As System.Object, e As System.EventArgs) Handles btnIC.Click
        Dim r1 As DataRow = myFormats.rDocu(Me.Controller, frmIDX, "ic", "Panel Interconnections", "", "")
        Dim oRet As clsProcOutput = pView.fParentWin.GenerateIDOutput("ic", myUtils.cValTN(frmIDX))
        If oRet.Success Then
            myFormats.fncTC(myView, "ic", oWO, r1, oRet.Data, True, Me.cmb_Mode.Value)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub
End Class
