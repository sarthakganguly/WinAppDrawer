Public Class appVerticalDrawer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        appDrawerName.Text = "Test Name"

    End Sub

    Private Sub addAppBut_Click(sender As Object, e As RoutedEventArgs) Handles addAppBut.Click
        Dim newAPP As New app
        newAPP.Height = 128
        newAPP.Width = 128
        appStackPanel.Children.Add(newAPP)
    End Sub

End Class
