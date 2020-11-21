Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization
Imports risersoft.shared.dotnetfx

<DataContract>
Public Class frmCtlMtgModel
    Inherits clsFormDataModel
    Dim myFuncsVC As New clsFuncsVC(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("MtgItem")
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
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "Select * from ctlmtg where ctlmtgid = " & prepIDX
        Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

        myView.MainGrid.MainConf("showrownumber") = True
        myView.MainGrid.QuickConf("select ctlmtgitemid, ctlmtgid, ItemId, Qty from CtlMtgItem where ctlmtgid=" & frmIDX, True, "4-1", True, "Mounting Items")
        Dim str1 As String = "<BAND INDEX=""0"" TABLE=""ctlmtgitem"" IDFIELD=""ctlmtgitemid"" ><COL KEY=""ctlmtgid,qty""/><COL KEY=""ItemID"" NOEDIT=""True"" CAPTION=""Item"" LOOKUPSQL=""Select itemid, itemcode + ' - ' + itemname as item from items""/></BAND> "
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim lastmode As EnumfrmMode = frmMode
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("ctlmtgid")
                frmMode = EnumfrmMode.acEditM
                Me.myView.MainGrid.SaveChanges(, "ctlmtgid=" & frmIDX)
                myFuncsVC.MountingDataSet(True)

                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
