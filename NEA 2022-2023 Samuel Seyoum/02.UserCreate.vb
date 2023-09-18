Public Class UserCreate

    'Constructor
    Public Sub New(ByVal oForname As String, ByVal oSurname As String, ByVal oUsername As String, ByVal oPassword As String)
        'Constructor takes 4 strings as arguments

        InitializeComponent()
        'Visual Basic built in constructor for forms

        txtbxFName.Text = oForname
        txtbxSName.Text = oSurname
        txtbxUName.Text = oUsername
        txtbxPass.Text = oPassword
        txtbxCPAss.Text = oPassword
        'Constructor takes values for textboxes so that, when going back from UserCreate2, the same values are still there
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
        Dim fWelcome As New Welcome
        'Instantiate Welcome form

        Me.Hide()
        fWelcome.Show()
        'Open instantiated Welcome form
    End Sub

    'When btnContinue is clicked
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        lblEmpty.Visible = False
        lblMatch.Visible = False
        lblNotEnough.Visible = False
        'Makes all error messages invisible as only 1 shows at a time

        If txtbxFName.Text = "" Or txtbxSName.Text = "" Or txtbxUName.Text = "" Or txtbxPass.Text = "" Or txtbxCPAss.Text = "" Then
            lblEmpty.Visible = True
            'If any textbox is empty, show empty error message
        ElseIf txtbxCPAss.Text <> txtbxPass.Text Then
            lblMatch.Visible = True
            'If passwords do not match, show password match error message
        ElseIf Len(txtbxPass.Text) < 8 Or UCase(txtbxPass.Text) = txtbxPass.Text Or LCase(txtbxPass.Text) = txtbxPass.Text Or Not HasNumber(txtbxPass.Text) Or Not hasLetter(txtbxPass.Text) Or Not hasSpecial(txtbxPass.Text) Then
            lblNotEnough.Visible = True
            'If password does not meet requirements (length > 8, 1 upper, 1 lower, 1 number, 1 special character), show insufficient password error message
        Else
            Dim fUserCreate2 As New UserCreate2(txtbxFName.Text, txtbxSName.Text, txtbxUName.Text, txtbxPass.Text)
            'Instantiates UserCreate2 form, passing forename, surname, username and password as parameters to the constructor

            Me.Hide()
            fUserCreate2.Show()
            'Opens instantiated UserCreate2 form
        End If
    End Sub
End Class