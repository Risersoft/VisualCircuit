Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmCtlCatModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim oRet As clsProcOutput = Me.GetRowLock(prepMode, "CtlCatId", prepIDX)
        If oRet.Success Then
            If frmMode = EnumfrmMode.acAddM Then prepIDX = 0
            Dim Sql As String = "Select * from CtlCat where CtlCatId = " & myUtils.cValTN(prepIDX)
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)
            Me.FormPrepared = True
        Else
            Me.AddError("", Nothing, 0, "", "", oRet.Message)
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("CtlCat")).Trim.Length = 0 Then Me.AddError("CtlCat", "Enter Category")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                Me.ChangeModeGetLock("CtlCatId")
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
