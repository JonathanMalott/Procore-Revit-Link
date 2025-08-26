Imports Autodesk.Revit.UI
Imports System
Imports System.Windows.Controls

Public Class App
    Implements IExternalApplication

    Public Function OnStartup(application As UIControlledApplication) As Result Implements IExternalApplication.OnStartup
        Try
            Dim paneId As New DockablePaneId(New Guid("0B2B77D3-5F39-4BE2-AD13-88364C1242A7"))
            Dim pane As New ProcorePane()
            application.RegisterDockablePane(paneId, "Procore", pane)
            Return Result.Succeeded
        Catch ex As Exception
            TaskDialog.Show("Procore Revit Link", ex.Message)
            Return Result.Failed
        End Try
    End Function

    Public Function OnShutdown(application As UIControlledApplication) As Result Implements IExternalApplication.OnShutdown
        Return Result.Succeeded
    End Function
End Class
