Imports System.Windows.Controls

Public Class ProcorePane
    Inherits UserControl

    Public Sub New()
        Dim browser As New WebBrowser()
        browser.Navigate("https://www.procore.com")
        Content = browser
    End Sub
End Class
