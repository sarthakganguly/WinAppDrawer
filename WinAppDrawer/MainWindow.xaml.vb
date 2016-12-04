Class MainWindow
    Private Sub addDrawerBut_Click(sender As Object, e As RoutedEventArgs) Handles addDrawerBut.Click

        Dim newDrawer As New appVerticalDrawer
        appStack.Children.Add(newDrawer)

    End Sub

    Private Sub setSizeBut_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) _
        Handles setSizeBut.MouseLeftButtonDown
        Try
            Me.Height = CInt(setHeightTBox.Text)
            Me.Width = CInt(setWidthTBox.Text)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub



End Class
