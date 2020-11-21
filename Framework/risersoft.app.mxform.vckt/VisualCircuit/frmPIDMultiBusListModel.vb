Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDMultiBusListModel
    Inherits clsFormDataModel
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
        If frmMode = EnumfrmMode.acEditM Then
            Dim Sql As String = "select * from desListPidUnittot() where PidUnitId = " & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

            Sql = "select * from pidctlbus where isnull(multitfmb,0)=1 and pidunitid=" & frmIDX
            Me.AddDataSet("PidCtlBus", Sql)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function
End Class
