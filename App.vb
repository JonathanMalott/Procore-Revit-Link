Imports Autodesk.Revit.UI
Imports System
Imports System.Windows.Controls
Imports System.Reflection
Imports System.Linq

Public Class App
    Implements IExternalApplication

    Public Function OnStartup(application As UIControlledApplication) As Result Implements IExternalApplication.OnStartup
        Try
            ' Create Procore-Link ribbon tab and panel
            Const tabName As String = "Procore-Link"

            Try
                application.CreateRibbonTab(tabName)
            Catch
                ' Tab already exists
            End Try

            Dim panel As RibbonPanel
            Try
                panel = application.CreateRibbonPanel(tabName, "Procore Link")
            Catch
                panel = application.GetRibbonPanels(tabName).First(Function(p) p.Name = "Procore Link")
            End Try

            ' Add Hello World button
            Dim assemblyPath As String = Assembly.GetExecutingAssembly().Location
            Dim buttonData As New PushButtonData("HelloWorldButton", "Hello World", assemblyPath, "ProcoreRevitLink.HelloWorldCommand")
            panel.AddItem(buttonData)

            ' Register and show Procore dockable pane
            Dim paneId As New DockablePaneId(New Guid("0B2B77D3-5F39-4BE2-AD13-88364C1242A7"))
            Dim pane As New ProcorePane()
            application.RegisterDockablePane(paneId, "Procore", pane)
            application.GetDockablePane(paneId).Show()

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
