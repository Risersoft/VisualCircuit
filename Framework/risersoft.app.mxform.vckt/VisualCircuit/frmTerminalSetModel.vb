Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTerminalSetModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("CTerm")
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
        Dim sql As String = "Select * from ctlterminalset where ctlterminalsetid = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        myView.MainGrid.MainConf("showrownumber") = True
        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""TerminalName"" CAPTION=""Name""/><COL KEY=""TextAlign"" CAPTION=""Align"" VLIST=""1;Left|2;Right""/>"
        myView.MainGrid.QuickConf("select ctlterminalid,ctlterminalid as termid, terminalwidth,wirewidth,ctlterminalsetid,TerminalLocX,TerminalLocY,WireLocX,WireLocY,TerminalName,TextAlign from CtlTerminal where ctlterminalsetid=" & frmIDX, True, "4-1", True, "Terminal Setup and Location")
        Dim str1 As String = "<BAND INDEX=""0"" TABLE=""ctlterminal"" IDFIELD=""ctlterminalid"" ><COL KEY=""ctlterminalsetid,TerminalName,TextAlign""/><COL KEY=""terminalwidth,wirewidth,TerminalLocX,TerminalLocY,WireLocX,WireLocY"" NOEDIT=""True"" /></BAND> "
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        myContext.Tables.SetAuto(myView.MainGrid.myDS.Tables(0), Nothing, "termid")
       
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
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                frmIDX = myRow("CtlTerminalSetId")
                frmMode = EnumfrmMode.acEditM

                Me.myView.MainGrid.SaveChanges(, "CtlTerminalSetId=" & frmIDX)
                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
