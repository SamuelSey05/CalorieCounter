Public Class AView

    'When btnVStudent is clicked
    Private Sub btnVStudent_Click(sender As Object, e As EventArgs) Handles btnVStudent.Click
        Dim fAStudentView As New AStudentView
        'Instantiate AStudentView form

        Me.Hide()
        fAStudentView.Show()
        'Open instantiated AStudentView form
    End Sub

    'Whwn btnVGroup is clicked
    Private Sub btnVGroup_Click(sender As Object, e As EventArgs) Handles btnVGroup.Click
        Dim fGroupView As New AGroupView
        'Instantiate GroupView form

        Me.Hide()
        fGroupView.Show()
        'Open instantiated GroupView
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fAMainMenu As New AMainMenu
        'Instantiate AMainMenu

        Me.Hide()
        fAMainMenu.Show()
        'Open instantiated AMainMenu
    End Sub
End Class