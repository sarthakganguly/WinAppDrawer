Public Class app

    Private setAction As String
    Public Property set_Action() As String
        Get
            Return setAction
        End Get
        Set(ByVal value As String)
            setAction = value
        End Set
    End Property

    Private Sub delAppBut_Click(sender As Object, e As RoutedEventArgs) Handles delAppBut.Click
        Me.Finalize()
    End Sub

End Class
