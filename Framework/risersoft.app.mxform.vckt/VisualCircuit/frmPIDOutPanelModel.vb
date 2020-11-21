Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDOutPanelModel
    Inherits clsFormDataModel
    Dim myViewWD, myViewLug, myViewLbl, myViewHW, myViewMat, myViewBOMR, myViewBOMNR, myViewLeg As clsViewModel
    Dim oWO As clsWOInfoBase
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("TB")
        myViewWD = Me.GetViewModel("WD")
        myViewLug = Me.GetViewModel("Lug")
        myViewLbl = Me.GetViewModel("Lbl")
        myViewHW = Me.GetViewModel("HW")
        myViewMat = Me.GetViewModel("Mat")
        myViewBOMR = Me.GetViewModel("BOMR")
        myViewBOMNR = Me.GetViewModel("BOMNR")
        myViewLeg = Me.GetViewModel("Leg")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim vlist1 As New clsValueList
        vlist1.Add("Printer")
        vlist1.Add("PDF")
        Me.ValueLists.Add("Mode", vlist1)
        Me.AddLookupField("Mode", "Mode")
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1, Strf1, PanelCode As String
        Me.FormPrepared = False
        oWO = myPIDU.GenerateWOInfo(myContext, prepIDX)
        If Me.InitData(oWO.rPIDU, oView, prepIDX) Then
            Me.vBag = Me.PrepVBag(strXML, oView.ContextRow, "PanelCode")
            PanelCode = Me.vBag("PanelCode")
            Strf1 = GenerateStrf1(myUtils.cValTN(frmIDX), myUtils.cStrTN(PanelCode))

            Dim strf2 As String = "pidctlbusid in (select pidctlbusid from ctslistpidctlterm() where " & Strf1 & ")"

            myView.MainGrid.MainConf("sortcolsasc") = "TerminalName"
            myView.MainGrid.MainConf("defaultgroupon") = "Legend"
            sql = "select Location,Legend,LocInt,DeviceInt,WireNum,TerminalName,WireLoop,LocExt,DeviceExt,CableDescripTB from ctsListPIDTB() where " & Strf1
            myView.MainGrid.QuickConf(sql, True, "1-1-1-1-1-1-1-2", True)

            myViewWD.MainGrid.MainConf("sortcolsasc") = "WireNum"
            myViewWD.MainGrid.MainConf("showrownumber") = True
            sql = "select pidctlbus.pidctlbusid, multitfmb,pidunitid, WireNum, SQMM, Color, TermList, LugList from pidctlbuspanel inner join PIDCtlBus on pidctlbuspanel.pidctlbusid = pidctlbus.pidctlbusid where pidctlbus." & strf2 & " and panelcode='" & PanelCode & "'"
            myViewWD.MainGrid.QuickConf(sql, True, "1-1-1-3-3", True)

            sql = "select pidunitid,loc, itemid, ItemCode,ItemName, sum(lugqty) as Qty from ctsListPIDCtlLug() where " & Strf1 & " group by itemid, itemcode,itemname,loc,pidunitid"
            myViewLug.MainGrid.QuickConf(sql, True, "1-3-1", True)

            sql = "SELECT itemid, ItemCode, ItemName, Qty FROM ctslistPIDCTLItems() WHERE " & Strf1
            myViewLbl.MainGrid.QuickConf(sql, True, "1-3-1", True)

            sql = "SELECT itemid, ItemCode, ItemName, Qty FROM ctslistPIDCTLMtgItem() WHERE " & Strf1
            myViewHW.MainGrid.QuickConf(sql, True, "1-3-1", True)

            strf2 = "<VIEW KEY=""listpidctl""><MODROWCOMPLEX>"
            strf2 = strf2 & "<MODROW VIEWKEY=""listpidctl""><SQLWHERE2>" & Strf1 & "</SQLWHERE2></MODROW>"
            strf2 = strf2 & "<MODROW VIEWKEY=""listpidctlbom""><SQLWHERE2>" & Strf1 & "</SQLWHERE2></MODROW>"
            strf2 = strf2 & "</MODROWCOMPLEX></VIEW>"
            myContext.Provider.ProcessTag(myViewMat, strf2)

            str1 = myUtils.CombineWhere(False, Strf1, "isnull(legend,'') not in ('-','')")
            sql = "SELECT GAName, GAUse, GARating, LegendsGA, sum(qtynum) as Qty, GAMakes FROM deslistpidctl() WHERE " & str1 & " GROUP BY GAName, GAUse, GARating, LegendsGA, GAMakes"
            myViewBOMR.MainGrid.QuickConf(sql, True, "1-1-2-1-1-2", True)

            sql = "SELECT GAName, GAUse, LegendsGA, sum(qtynum) as Qty, GAMakes FROM deslistpidctl() WHERE " & str1 & " GROUP BY GAName, GAUse, LegendsGA, GAMakes"
            myViewBOMNR.MainGrid.QuickConf(sql, True, "1-1-1-1-2", True)

            sql = "SELECT GAName, GAUse, LegendsGA FROM deslistpidctl() WHERE " & str1 & " GROUP BY GAName, GAUse, LegendsGA"
            myViewLeg.MainGrid.QuickConf(sql, True, "1-1-1", True)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Function GenerateStrf1(PidUnitID As Integer, PanelCode As String) As String
        Dim Strf1 As String = "PidUnitId=" & PidUnitID & " and Location='" & PanelCode & "'"
        Return Strf1
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Dim PidUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitID", Params))
            Dim PanelCode As String = myUtils.cStrTN(myContext.SQL.ParamValue("@PanelCode", Params))
            Dim Strf1 As String = GenerateStrf1(PidUnitID, PanelCode)
            Select Case dataKey.Trim.ToUpper
                Case "TB"
                    Dim Sql As String = "select * from ctsListPIDTB() where " & Strf1
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
                Case "WD"
                    Dim dic As New clsCollecString(Of String)
                    dic.Add("wd", "SELECT * FROM deslistPIDCTL() WHERE " & myUtils.CombineWhere(False, "haswd=1", Strf1))
                    dic.Add("wl", "select pidctlid,pidunitid,wirenum,pidctlbuspanel.lugqty, termlist,color,sqmm from pidctlbuspanel inner join pidctlbus on pidctlbuspanel.pidctlbusid = pidctlbus.pidctlbusid inner join pidctlterm on pidctlterm.pidctlbusid = pidctlbus.pidctlbusid where isnull(pidctlbuspanel.termlist,'')<>'' and pidctlbus.pidunitid=" & PidUnitID & " and pidctlbuspanel.panelcode='" & PanelCode & "'")
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
                Case "ML"
                    Dim dic As New clsCollecString(Of String)
                    dic.Add("ctl", "select * from deslistpidctl() where " & myUtils.CombineWhere(False, Strf1, "isnull(DontPrintInMatList,0)=0") & " order by make desc, itemcode")
                    dic.Add("ctlBOM", "select * from deslistpidctlBOM() where " & myUtils.CombineWhere(False, Strf1) & " order by itemvmsbomid")
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
                Case "LHPANEL"
                    Dim dic As New clsCollecString(Of String)
                    dic.Add("lbl", "SELECT * FROM ctslistPIDCTLItems() WHERE " & Strf1)
                    dic.Add("hw", "SELECT * FROM ctslistPIDCTLMtgItem() WHERE " & Strf1)
                    dic.Add("lug", "Select pidunitid,loc, itemid, ItemCode,ItemName, sum(lugqty) as Qty from ctsListPIDCtlLug() where " & Strf1 & " group by itemid, itemcode,itemname,loc,pidunitid")
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
                Case "LHPIDU"
                    Dim dic As New clsCollecString(Of String)
                    dic.Add("lbl", "SELECT * FROM ctslistPIDCTLItems() WHERE pidunitid=" & PidUnitID)
                    dic.Add("hw", "SELECT * FROM ctslistPIDCTLMtgItem() WHERE pidunitid=" & PidUnitID)
                    dic.Add("lug", "select pidunitid,loc, itemid, ItemCode,ItemName, sum(lugqty) as Qty from ctsListPIDCtlLug() where pidunitid=" & PidUnitID & " group by itemid, itemcode,itemname,loc,pidunitid")
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateDataOutput(dataKey As String, ds As DataSet, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey
            Case "save"
                Try
                    myContext.Provider.objSQLHelper.SaveResults(ds.Tables(0), "select pidctlpanelid, drawingnotetb from pidctlpanel where pidctlpanelid=0")
                Catch ex As Exception
                    oRet.AddException(ex)
                End Try
        End Select
        Return oRet
    End Function
End Class
