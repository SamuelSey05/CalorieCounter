Public Class AUserManage2


    Dim user As Student
    'Creates local variable user (Student)

    Public Sub New(ByVal iUser As Student)
        'Takaes Student as an argument

        InitializeComponent()
        'Visual Basic built in constructor for forms

        user = iUser
        'Constructor takes value into local variable to be passed into new forms 
    End Sub

    'When form loads
    Private Sub AUserManage2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Text = user.Username
        'Make text at top of form username of specified user
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        'Close this form
        'No form needs to be opened because this form only appears in front of other forms
    End Sub

    'When btnDelete is clicked
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If MsgBox("Click Ok to delete student", 1) = 1 Then
            'Use an Ok/Cancel message box
            user.deleteUser()
            'if Ok is clicked on the message box, delete user

            Me.Hide()
            'Close this form
            'No form needs to be opened because this form only appears in front of other forms
        End If
    End Sub

    'When btnEUser is clicked 
    Private Sub btnEUser_Click(sender As Object, e As EventArgs) Handles btnEUser.Click
        Dim fAUserManage3 As New AUserManage3(user)
        'Instantiate AUserManage3, passing user as a parameter to the constructor

        Me.Hide()
        fAUserManage3.ShowDialog()
        'Open instantiated AUserManage3 in front of open form
    End Sub

    'When btnResetPass is clicked
    Private Sub btnResetPass_Click(sender As Object, e As EventArgs)
        If MsgBox("Click Ok to reset password", 1) = 1 Then
            'Use an Ok/Cancel message box
            user.Password = "Student,123"
            'if Ok is clicked on the message box, set user password to default
            user.updatePassword()
            'Update password on database

            Me.Hide()
            'Close this form
            'No form needs to be opened because this form only appears in front of other forms
        End If
    End Sub
End Class