Public Class Welcome

    'When btnLogin is clicked
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim fLogin As New Login
        'Instantiate Login form 

        Me.Hide()
        fLogin.Show()
        'Open instantiated Login form
    End Sub

    'When btnCreate is clicked
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim fUserCreate As New UserCreate("", "", "", "")
        'Instantiate UserCreate form with empty textboxes

        Me.Hide()
        fUserCreate.Show()
        'Open instantiated UserCreate form
    End Sub

End Class
