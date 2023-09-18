Public Class Login

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fWelcome As New Welcome
        'Instantiate Welcome form

        Me.Hide()
        fWelcome.Show()
        'Opens instantiated Welcome form
    End Sub

    'When btnLogin is clicked
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblIncorrect.Visible = False
        lblEmpty.Visible = False
        'Makes all error messges invisible

        If txtbxUName.Text = "Admin1" And txtbxPass.Text = "Brocoli,23" Then
            Dim fAMainMenu As New AMainMenu
            'If correct admin username and password are inputted, instantiate AMainMenu form

            Me.Hide()
            fAMainMenu.Show()
            'Open instantiated AMainMenu form
        ElseIf txtbxUName.Text = "" Or txtbxPass.Text = "" Then
            lblEmpty.Visible = True
            'If username or passsword textboxes are empty, show empty error message
        Else
            Dim student As New Student(txtbxUName.Text)
            'Instantiate new student with username in txtbxUName
            student.getDetails()
            'Get all details about student from database
            'If student is not in database, empty values will be returned

            If student.Password = txtbxPass.Text Then
                Dim fSMainMenu As New SMainMenu(student)
                'If stuednt is on database and password matches txtbxPass, instantiate SMainMenu form, passing student as a parameter to the constructor

                Me.Hide()
                fSMainMenu.Show()
                'Open instantiated SMainMenu form
            Else
                lblIncorrect.Visible = True
                'If username is not in database or txtbxPass.Text does not match password, shwo incorrect error message
            End If
        End If
    End Sub

    'When a key is pressed in txtbxPass
    Private Sub txtbxPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxPass.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin_Click(Me, EventArgs.Empty)
            'If key pressed is enter key, run same subroutine that happens when btnLogin is clicked
        End If
    End Sub

    'When a key is pressed in txtbxUName
    Private Sub txtbxUName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxUName.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin_Click(Me, EventArgs.Empty)
            'If key pressed is enter key, run same subroutine that happens when btnLogin is clicked
        End If
    End Sub
End Class