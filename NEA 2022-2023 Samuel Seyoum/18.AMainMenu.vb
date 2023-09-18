Public Class AMainMenu
    Private Sub btnUserMan_Click(sender As Object, e As EventArgs) Handles btnUserMan.Click
        Dim fAUserManage As New AUserManage
        'Instanitate AUserManage form

        Me.Hide()
        fAUserManage.Show()
        'Opens instantiated AUserManage form
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim fAView As New AView
        'Instantiate AView form

        Me.Hide()
        fAView.Show()
        'Opens instantiated AView form
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MsgBox("Click Ok to log out", 1) = 1 Then
            'Use an Ok/Cancel message box
            Dim fWelcome As New Welcome
            'If Ok is clicked on the message box, intantiate Welcome form

            Me.Hide()
            fWelcome.Show()
            'Open instantiated Welcome form
        End If
    End Sub
End Class