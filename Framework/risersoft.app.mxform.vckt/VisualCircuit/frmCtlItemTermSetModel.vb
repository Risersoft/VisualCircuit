Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization
Imports risersoft.shared.dotnetfx

<DataContract>
Public Class frmCtlItemTermSetModel
    Inherits clsFormDataModel
    Dim myFuncsVC As New clsFuncsVC(myContext)
    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "Select * from CtlItemTermSet where CtlItemTermSetId = " & prepIDX
        Me.InitData(Sql, "CtlItemId", oView, prepMode, prepIDX, strXML)

        Me.AddLookupField("CtlTerminalSetID", myUtils.AddTable(Me.dsCombo, myFuncsVC.dsTS, "TS").TableName)
        Me.DatasetCollection.Add("DsTs", myFuncsVC.dsTS)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("CtlItemTermSetId")
                frmMode = EnumfrmMode.acEditM
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
