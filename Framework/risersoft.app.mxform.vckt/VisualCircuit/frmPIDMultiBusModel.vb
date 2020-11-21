Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDMultiBusModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("PIDCtlTerm")
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
        Me.InitData("", "", oView, prepMode, prepIDX)

        Me.vBag = Me.PrepVBag(strXML, oView.ContextRow, "PidCtlBusId")
        Dim PidCtlBusId As Integer = Me.vBag("PidCtlBusId")

        myView.MainGrid.MainConf("showrownumber") = True
        Dim Sql As String = "select panelcode,pidctlid,terminaltot,paneltype,istb,pidctltermid,pidctlbusid,wirenum,Ctlcat,upper(Location) as Location, Legend, TerminalName, pidctltermid2 from desListPIDCtlTerm() where (paneltype in (4) or isnull(istb,0)=1) and pidctlbusid = " & PidCtlBusId
        Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)
        myView.MainGrid.BindGridData(dt1.DataSet, 0)
        myView.MainGrid.QuickConf("", True, "1-1-1-3", , "Devices using the selected wire bus no.")
        myView.MainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY=""pidctltermid2""/></BAND>", EnumEditType.acCommandAndEdit)

        Dim dt2 As DataTable = dt1.Copy
        myUtils.DeleteRows(dt2.Select("isnull(istb,0)=0"))
        myUtils.MakeDSfromTable(dt2, False)
        Me.DatasetCollection.Add("PCTerm", dt2.DataSet)

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
                myContext.Provider.objSQLHelper.SaveResults(myView.MainGrid.myDS.Tables(0), "select pidctltermid,pidctltermid2 from pidctlterm where pidctltermid=0")
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class