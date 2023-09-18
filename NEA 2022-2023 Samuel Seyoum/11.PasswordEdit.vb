Public Class PasswordEdit

    Dim user As Student
    'Creats local variable user (Student)

    'Constructor
    Public Sub New(ByVal iUser As Student)
        'Takes a Student as an argument

        InitializeComponent()
        'Visual Basic built in constructor

        user = iUser
        'Constructor takes value into local variable to be used in editing password and to be passed into the next forms
    End Sub

    'Checks if a string has a number in it
    Private Function hasNumber(ByVal str As String) As Boolean
        'Takes a string as a parameter
        'Returnes a boolean
        For i = 0 To Len(str) - 1
            If IsNumeric(str(i)) Then
                Return True
                'Cycles through string to find a number, if found, returns True
            End If
        Next
        Return False
        'If no number found in string, return False
    End Function

    'Checks if a string has a letter in it
    Private Function hasLetter(ByVal str As String) As Boolean
        'Takes a string as a parameter
        'Returnes a boolean
        For i = 0 To Len(str) - 1
            If (UCase(Asc(str(i))) > 64 And UCase(Asc(str(i))) < 91) Then
                Return True
                'Cycles through string to find a letter, if found, returns True
            End If
        Next
        Return False
        'If no letter found in string, return False
    End Function

    'Checks if a string has a special character
    Private Function hasSpecial(ByVal str As String) As Boolean
        'Takes a string as a parameter
        'Returnes a boolean
        For i = 0 To Len(str) - 1
            If (Asc(str(i)) > 32 And Asc(str(i)) < 48) Or (Asc(str(i)) > 57 And Asc(str(i)) < 65) Or (Asc(str(i)) > 90 And Asc(str(i)) < 96) Or (Asc(str(i)) > 122 And Asc(str(i)) < 127) Then
                'Ranges of ASCII values that correspond to special characters
                Return True
                'Cycles through string to find a special character, if found, returns True
            End If
        Next
        Return False
        'If no special character found in string, return False
    End Function

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fUserEdit As New UserEdit(user)
        'Instantiate UserEdit form, passing user as a parameter to the constructor

        Me.Hide()
        fUserEdit.Show()
        'Open instantiated UserEdit form
    End Sub

    'When btnOK is clicked
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        lblCurrent.Visible = False
        lblMatch.Visible = False
        lblNotEnough.Visible = False
        'Makes all error messages invisible as only 1 shows at a time

        If txtbxOPass.Text <> user.Password Then
            lblCurrent.Visible = True
            'If current password does not match txtbxOPass, show current password error message
        ElseIf txtbxNPass.Text <> txtbxCNPass.Text Then
            lblMatch.Visible = True
            'If new password textboxes do not match, show matching error mesage
        ElseIf Len(txtbxNPass.Text) < 8 Or UCase(txtbxNPass.Text) = txtbxNPass.Text Or LCase(txtbxNPass.Text) = txtbxNPass.Text Or Not hasNumber(txtbxNPass.Text) Or Not hasLetter(txtbxNPass.Text) Or Not hasSpecial(txtbxNPass.Text) Then
            lblNotEnough.Visible = True
            'If password does not meet requirements (length > 8, 1 upper, 1 lower, 1 number, 1 special character), show insufficient password error message
        Else
            user.Password = txtbxNPass.Text
            'Changes password of Student
            user.updatePassword()
            'Sends password update to database

            MsgBox("Password change successful")

            Dim fSMainMenu As New SMainMenu(user)
            'Instantiates SMainMenu form, passing user as a parameter to the constructor

            Me.Hide()
            fSMainMenu.Show()
            'Opens instantiated SMainMenu form
        End If
    End Sub
End Class