Public Class UserEdit

    Dim user As Student
    'Creates local variable user (Student)

    'Constructor
    Public Sub New(ByVal iUser As Student)
        'Takes a Student as an argument

        InitializeComponent()
        'Visual Basic built in constructor for forms

        user = iUser
        'Constructor takes value into local variable to be passed into new forms
    End Sub

    'WHen btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fSMainMenu As New SMainMenu(user)
        'Instantiate SMainMenu form passing user as a parameter to the constructor

        Me.Hide()
        fSMainMenu.Show()
        'Open instantiated SMainMenu form
    End Sub

    'When btnEPass is clicked
    Private Sub btnEPass_Click(sender As Object, e As EventArgs)
        Dim fPasswordEdit As New PasswordEdit(user)
        'Instantiate PasswordEdit form, passing user as a parameter to the constructor

        Me.Hide()
        fPasswordEdit.Show()
        'Open instantiated PasswordEdit form
    End Sub

    'Wnen btnEDets is clicked
    Private Sub btnEDets_Click(sender As Object, e As EventArgs) Handles btnEDets.Click
        Dim fDetailEdit As New DetailEdit(user)
        'Instantiate DetailEdit form, passing user as a parameter to the constructor

        Me.Hide()
        fDetailEdit.Show()
        'Open instantiated Detail Edit form
    End Sub

    'When btnDelete is clicked
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If MsgBox("Click Ok to delete user", 1) = 1 Then
            'Use an Ok/Cancel message box
            user.deleteUser()
            'If Ok is clicked on the message box, delete user

            Dim fWelcome As New Welcome
            'Instantiate Welcome form

            Me.Hide()
            fWelcome.Show()
            'Open instantiated Welcome form
        End If
    End Sub
End Class