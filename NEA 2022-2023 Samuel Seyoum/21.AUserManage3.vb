Public Class AUserManage3

    Dim user As Student
    'Creates local variable user (Student)

    'Constructor
    Public Sub New(ByVal iUser As Student)
        'Tales a Student as an argument

        InitializeComponent()
        'Visual Basic built in constructor

        user = iUser
        'Constructor takes value into local variable to be used in editing the user
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        'Close this form
        'No form needs to be opened because this form only appears in front of other forms
    End Sub

    'Update the student in the table
    Private Sub updateStudent()

        If rbtnInactive.Checked Then
            user.PAL = 1.4
            'If the radio button associated with inactive is checked, set user.PAL to 1.4
        ElseIf rbtnSedentary.Checked Then
            user.PAL = 1.55
            'If the radio button associated with sedentary is checked, set user.PAL to 1.55
        ElseIf rbtnModerate.Checked Then
            user.PAL = 1.85
            'If the radio button associated with moderate activity is checked, set user.PAL to 1.85
        ElseIf rbtnVigorous.Checked Then
            user.PAL = 2.2
            'If the radio button associated with vigorous activity is checked, set user.PAL to 2.2
        ElseIf rbtnExtreme.Checked Then
            user.PAL = 2.4
            'If the radio button associated with extreme activity is checked, set user.PAL to 2.4
        End If
        'No else statement is needed as, if none of the radio buttons are checked, the empty error message will be shown, and this function will not be called

        If rbtnLose.Checked Then
            user.Goal = -1
            'If the radio button associated with losing weight is checked, set user.goal to -1
        ElseIf rbtnMaintain.Checked Then
            user.Goal = 0
            'If the radio button associated with maintaining weight is checked, set user.goal to 0
        ElseIf rbtnGain.Checked Then
            user.Goal = 1
            'If the radio button associated with gaining weight is checked, set user.goal to 1
        End If
        'No else statement is needed as, if none of the radio buttons are checked, the empty error message will be shown, and this fucntion will not be called

        user.Height = CDbl(txtbxHeight.Text)
        user.Weight = CDbl(txtbxWeight.Text)
        user.BFP = CDbl(txtbxBFP.Text)
        user.DOB = dtpDOB.Value
        'Set the users BFP, height, weight and DOB to the new values in the corresponding textboxes

        user.updateDetails()
        'Updates the details of the Student on the database
    End Sub

    'When the form loads
    Private Sub AUserManage3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Text = user.Username
        'Make the text at the top of the page the username of the specified user
        txtbxHeight.Text = user.Height
        txtbxWeight.Text = user.Weight
        txtbxBFP.Text = user.BFP
        dtpDOB.Value = user.DOB
        'Put the values of height, weight, BFP and DOB into their corresponding textboxes

        Select Case user.PAL
            Case 1.4
                rbtnInactive.Checked = True
                'If the PAL is 1.4, check the radio button associated with inactive
            Case 1.55
                rbtnSedentary.Checked = True
                'If the PAL is 1.55, check the radio button associated with sedentary
            Case 1.85
                rbtnModerate.Checked = True
                'If the PAL is 1.85, check the radio button associated with moderate activity
            Case 2.2
                rbtnVigorous.Checked = True
                'If the PAL is 2.2, check the radio button associated with vigorous activity
            Case 2.4
                rbtnExtreme.Checked = True
                'If the PAL is 2.4, check the radio button associated with extreme activity
        End Select

        Select Case user.Goal
            Case 1
                rbtnGain.Checked = True
                'If the goal is 1, check the radio button associated with gaining weight
            Case 0
                rbtnMaintain.Checked = True
                'If the goal is 0, check the radio button associated with maintaining weight
            Case -1
                rbtnLose.Checked = True
                'If the goal is -1, check the radio button associated with losing weight
        End Select
    End Sub

    'When btnConfirm is clicked
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        lblEmpty.Visible = False
        lblVDate.Visible = False
        lblVHeight.Visible = False
        lblVWeight.Visible = False
        lblVBFP.Visible = False
        'Make all error messages invisible, as only one is shown at a time

        If txtbxHeight.Text = "" Or txtbxWeight.Text = "" Or txtbxBFP.Text = "" Or Not (rbtnInactive.Checked Or rbtnSedentary.Checked Or rbtnModerate.Checked Or rbtnVigorous.Checked Or rbtnExtreme.Checked) Or Not (rbtnGain.Checked Or rbtnMaintain.Checked Or rbtnLose.Checked) Then
            lblEmpty.Visible = True
            'If any of the textboxes are empty, or if either of the activity or weight goal groups do not have a checked radio button, show the empty error message
        ElseIf (dtpDOB.Value - #8/31/2011#).Days > 0 Then
            lblVDate.Visible = True
            'If the date of birth is more recent than the latest date of birth possible for a student at the school, the user is deemed to be too young and the valid DOB error message is shown
        ElseIf Not IsNumeric(txtbxHeight.Text) Then
            lblVHeight.Visible = True
            'If the value in txtbxHeight is not numeric, show the valid height error message
        ElseIf txtbxHeight.Height < 0 Then
            lblVHeight.Visible = True
            'If the value in txtbxHeight is negative, show the valid height error message
        ElseIf Not IsNumeric(txtbxWeight.Text) Then
            lblVWeight.Visible = True
            'If the value in txtbxWeight is not numeric, show the valid weight error message
        ElseIf txtbxWeight.Text < 0 Then
            lblVWeight.Visible = True
            'If the value in txtbxWeight is negative, show the valid weight error message
        ElseIf Not IsNumeric(txtbxBFP.Text) Then
            lblVBFP.Visible = True
            'If the value in txtbxBFP is not numeric, show the valid BFP error message
        ElseIf txtbxBFP.Text < 0 Or txtbxBFP.Text > 100 Then
            lblVBFP.Visible = True
            'If the value in txtbxBFP is outside the range of values allowed for a percentage (0-100), show the valid BFP error message
        Else
            updateStudent()
            'Update the details of the student in the database

            MsgBox("Edits made.")

            Me.Hide()
            'Close current form
        End If
    End Sub
End Class