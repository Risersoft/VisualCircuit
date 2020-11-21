Imports risersoft.app.mxengg
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app.mxform.eto
Imports risersoft.app.visualcircuit
Imports risersoft.app.reports
Imports risersoft.app.shared.mxengg
Imports risersoft.app2.shared
Imports risersoft.chrome.winforms
Imports risersoft.shared.cloud
Imports risersoft.shared.dal
Imports risersoft.shared.portable.Models.Nav
Imports risersoft.shared
Imports risersoft.app.mxform.vckt

Public Class clsExtendAppVCKT
    Inherits clsAppExtendRsBase

    Protected Friend strApp As String = "vckt"

    Dim dic As clsCollecString(Of Boolean), FileProvider As ICloudFileProvider

    Public Overrides Function GetLicProductInfo() As LicProductInfo
        Return New LicProductInfo("vckt", 1.0, "VisualCircuit.Std")
    End Function

    Public Overrides Function AboutBox() As risersoft.shared.IForm
        Return New frmAboutBox
    End Function

    Public Overrides Function StartupAppCode() As String
        Return strApp
    End Function

    Public Overrides Sub UpdateSettings(s As risersoft.shared.myAppSettings)
        s.RelateLoginPerson = True
        s.AppLoadBehaviour = EnumLoadBehaviour.acForceDB
    End Sub

    Public Overrides Function dicWOInfoTypes() As clsCollecString(Of Type)

        If dicWOInfo Is Nothing Then
            dicWOInfo = New clsCollecString(Of Type)
            dicWOInfo.Add(GetType(clsWOInfo).Name, GetType(clsWOInfo))
            dicWOInfo.Add(GetType(clsWOInfoUCAD).Name, GetType(clsWOInfoUCAD))
        End If
        Return dicWOInfo


    End Function
    Public Overrides Function fViewer2D() As IViewer
        Return New frmBrowserViewer
    End Function
    Public Overrides Function fViewer3D() As IViewer
        Return New frmBrowserViewer
    End Function
    Public Overrides Function OnAppInit(oApp As clsCoreApp) As Boolean
        myDWGView.RegisterCADImport()
        Return True
    End Function

    Public Overrides Function FileProviderClient(context As IProviderContext, AppCode As String, ProviderCode As String) As clsFileProviderClientBase
        Dim provider As clsFileProviderClientBase
        Select Case ProviderCode.Trim.ToLower
            Case "blob"
                If FileProvider Is Nothing Then FileProvider = ProviderFactory.CreateFileProvider(context)
                provider = New clsBlobFileClient(context, AppCode, FileProvider)
            Case Else
                provider = MyBase.FileProviderClient(context, AppCode, ProviderCode)
        End Select
        Return provider
    End Function




    Public Overrides Function CreateDataProvider(context As clsAppController, cb As IAsyncWCFCallBack) As IAppDataProvider
        Dim Provider As IAppDataProvider = ProviderFactory.CreateDataProvider(context, cb)
        Return Provider

    End Function

    Public Overrides Function dicFormModelTypes() As clsCollecString(Of Type)
        If dicFormModel Is Nothing Then
            dicFormModel = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicFormModel, GetType(frmGenPersonModel).Assembly, GetType(clsFormDataModel))
            Me.AddTypeAssembly(dicFormModel, GetType(frmPIDSchemeModel).Assembly, GetType(clsFormDataModel))
        End If
        Return dicFormModel
    End Function

    Public Overrides Function dicTaskProviderTypes() As clsCollecString(Of Type)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function dicReportProviderTypes(myContext As clsAppController) As clsCollecString(Of Type)
        If dicReportModelProvider Is Nothing Then
            dicReportModelProvider = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicReportModelProvider, GetType(pbomReportDataProvider).Assembly, GetType(clsReportDataProviderBase))
        End If
        Return dicReportModelProvider
    End Function
    Public Overrides Function WOTabList(oWO As clsWOInfoBase) As List(Of String)
        Dim tl As New List(Of String)
        tl.AddRange(New String() {"params"})
        Return tl
    End Function
    Public Overrides Function ProgramName() As String
        Return "VisualCircuit"
    End Function

    Public Overrides Function NewDBName() As String
        Return "vcktdb"
    End Function

    Public Overrides Function MinDBVersion() As Decimal
        Return My.Settings.MinDBVersion
    End Function

    Public Overrides Function ProgramCode() As String
        Return "vckt"
    End Function
    Public Overrides Function FileServerRequired() As Boolean
        Return False
    End Function

    Public Overrides Function LinkLabel() As String
        Return "http://www.visualcircuit.com"
    End Function
    Public Overrides Function dicMat() As clsCollecString(Of Boolean)
        Return myFuncsBase.dicMat(False, False, False, True, False, False, False, False)
    End Function
End Class
