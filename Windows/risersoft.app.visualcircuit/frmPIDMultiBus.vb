Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto

Public Class frmPIDMultiBus
    Inherits frmMax
    Friend PidCtlBusId As Integer, fp As frmPIDMultiBusList

    Public Sub initForm()
        Me.UltraTabControl1.Style = UltraTabControlStyle.Wizard
        myView.SetGrid(Me.UltraGrid1)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("PIDCtlTerm"))
            myView.mainGrid.SetColLookup("pidctltermid2", Me.Model.DatasetCollection("PCTerm").Tables(0), "<STRWIDTH>1-1-1-0</STRWIDTH><REVERSEDIRECTION>TRUE</REVERSEDIRECTION>", , "ConnectedTo", "terminaltot", "pidctltermid")
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        strXML = "<PARAMS PidCtlBusId=""" & myUtils.cValTN(PidCtlBusId) & """/>"
        Dim objModel As frmPIDMultiBusModel = Me.InitData("frmPIDMultiBusModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            fp = CType(oview.fParent, frmPIDMultiBusList)
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function ValidateData() As Boolean
        Dim rr(), r1 As DataRow, cnt1 As Integer
        Me.InitError()

        cnt1 = fp.eBag.Select.Length
        For Each gr As UltraGridRow In myView.mainGrid.myGrid.Rows
            r1 = myWinUtils.DataRowFromGridRow(gr)
            If myUtils.cBoolTN(r1("istb")) Then
                If myUtils.cValTN(r1("pidctltermid2")) = myUtils.cValTN(r1("pidctltermid")) Then WinFormUtils.AddError(myView.mainGrid.myGrid, "Self Select", fp.eBag)
                rr = myView.mainGrid.myDS.Tables(0).Select("pidctltermid=" & myUtils.cValTN(r1("pidctltermid2")))
                If rr.Length > 0 AndAlso myUtils.cValTN(rr(0)("pidctltermid2")) <> r1("pidctltermid") Then WinFormUtils.AddError(myView.mainGrid.myGrid, "Terminal Cross Not Correct", fp.eBag)
            End If
        Next
        'check cross connections
        Return (fp.eBag.Select.Length = cnt1)
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Me.DoRefresh = True
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function
End Class

