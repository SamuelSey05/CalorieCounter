Public Class UserCreate2
    Private forename As String
    Private surname As String
    Private username As String
    Private password As String
    'Creates local variables foraname, surname, username and password (all strings)

    'Constructor
    Public Sub New(ByVal oForename As String, ByVal oSurname As String, ByVal oUsername As String, ByVal oPassword As String)
        'Constructor takes 4 strings as arguments

        InitializeComponent()
        'Visual Basic built in constructor for forms

        forename = oForename
        surname = oSurname
        username = oUsername
        password = oPassword
        'Constructor takes values into local variables to be used when creating new student and opening new forms
    End Sub

    'This function adds a student to the database and returns the Student created
    Private Function createStudent() As Student
        'Returns a student
        Dim PAL As Double
        Dim gender As String
        Dim goal As Integer
        'Creates local variables PAL (double), gender (string) and goal (integer)

        If rbtnInactive.Checked Then
            PAL = 1.4
            'If the radio button associated with inactive is checked, set PAL to 1.4
        ElseIf rbtnSedentary.Checked Then
            PAL = 1.55
            'If the radio button associated with sedentary is checked, set PAL to 1.55
        ElseIf rbtnModerate.Checked Then
            PAL = 1.85
            'If the radio button associated with moderate activity is checked, set PAL to 1.85
        ElseIf rbtnVigorous.Checked Then
            PAL = 2.2
            'If the radio button associated with vigorous activity is checked, set PAL to 2.2
        ElseIf rbtnExtreme.Checked Then
            PAL = 2.4
            'If the radio button associated with extreme activity is checked, set PAL to 2.4
        End If
        'No else statement is needed as, if none of the radio buttons are checked, the empty error message will be shown, and this function will not be called

        If rbtnLose.Checked Then
            goal = -1
            'If the radio button associated with losing weight is checked, set goal to -1
        ElseIf rbtnMaintain.Checked Then
            goal = 0
            'If the radio button associated with maintaining weight is checked, set goal to 0
        ElseIf rbtnGain.Checked Then
            goal = 1
            'If the radio button associated with gaining weight is checked, set goal to 1
        End If
        'No else statement is needed as, if none of the radio buttons are checked, the empty error message will be shown, and this fucntion will not be called

        If rbtnMale.Checked Then
            gender = "M"
            'If the radio button associated with male is checked, set gender to "M"
        ElseIf rbtnFemale.Checked Then
            gender = "F"
            'If the radio button associated with female is checked, get gender to "F"
        End If
        'No else statement is needed as, if none of the radio buttons are checked, the empty error message will be shown, and this function will not be called

        Dim student As New Student(username)
        'Instantiate a new Student with username
        student.setDetails(forename, surname, password, dtpDOB.Value, gender, CDbl(txtbxWeight.Text), CDbl(txtbxHeight.Text), CDbl(txtbxBFP.Text), PAL, goal)
        'Load details forename, surname, password, DOB, gender, weight, height, BFP, PAL and goal into user
        'Exception handling is not needed for the CDbl on txtbxWeight.Text, txtbxHeight.Text and txtbxBFP.Text because these values are checked using IsNumeric and if this is false, this function is not called

        Return student
        'Student is returned
    End Function

    'When the form loads
    Private Sub UserCreate2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = username
        'Set the text at the top of the page to the username passed in in the constructor
    End Sub

    'When btnCreate is clicked
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        lblEmpty.Visible = False
        lblVDate.Visible = False
        lblVHeight.Visible = False
        lblVWeight.Visible = False
        lblVBFP.Visible = False
        'Make all error messages invisible, as only one is shown at a time

        If txtbxHeight.Text = "" Or txtbxWeight.Text = "" Or Not (rbtnFemale.Checked Or rbtnMale.Checked) Or txtbxBFP.Text = "" Or Not (rbtnInactive.Checked Or rbtnSedentary.Checked Or rbtnModerate.Checked Or rbtnVigorous.Checked Or rbtnExtreme.Checked) Or Not (rbtnGain.Checked Or rbtnMaintain.Checked Or rbtnLose.Checked) Then
            lblEmpty.Visible = True
            'If any of the textboxes are empty, or if any of the gender, activity or weight goal groups do not have a checked radio button, show the empty error message
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
            Dim student As Student = createStudent()
            'Call the function createStudent and store the Student returned in student

            If student.addStudentToTable() Then

                Dim fSMainMenu As New SMainMenu(student)
                'If the student can be added to the table without error, instantiate SMainMenu form, passing student as a parameter to the constructor

                Me.Hide()
                fSMainMenu.Show()
                'Open instantiated SMainMenu form
            End If
        End If
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fUserCreate As New UserCreate(forename, surname, username, password)
        'Instantiates UserCreate form, passing forename, surname, username and password as parameters to the constructor

        Me.Hide()
        fUserCreate.Show()
        'Open instantiated UserCreate form
    End Sub
End Class