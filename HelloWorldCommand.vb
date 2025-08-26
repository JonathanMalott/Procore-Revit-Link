Imports Autodesk.Revit.UI
Imports Autodesk.Revit.DB

Public Class HelloWorldCommand
    Implements IExternalCommand

    Public Function Execute(commandData As ExternalCommandData, ByRef message As String, elements As ElementSet) As Result Implements IExternalCommand.Execute
        TaskDialog.Show("Procore Revit Link", "Hello World")
        Return Result.Succeeded
    End Function
End Class
