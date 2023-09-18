Public Class Student
    Public Property Username As String 'Unique username of student
    Public Property Forename As String 'Forename of student
    Public Property Surname As String 'Surname of student
    Public Property Password As String 'Password of student
    Public Property DOB As Date 'Date of birth of student
    Public Property Gender As String 'Gender of student
    Public Property Weight As Double 'Weight of student
    Public Property Height As Double 'Height of student
    Public Property BFP As Double 'Body fat percentage of student
    Public Property PAL As Double 'Physical activity level of student
    '1.4 - Inactive
    '1.55 - Sedentary
    '1.85 - Moderately active
    '2.2 - Vigorously active
    '2.4 - Extremely active
    Public Property Goal As Integer 'Goal of student
    '1 - Gain weight
    '0 - Maintain weight
    '-1 - Lose weight
    Public Property mCals As Double 'Maintenance calories of student
    Public Property Cals As Double 'Calories to be eaten per day by student
    Public Property Carbs As Double 'Carbs to be eaten per day by student
    Public Property Fats As Double 'Fats to be eaten per day by student
    Public Property Proteins As Double 'Proteins to be eaten per day by student
    'Public properties used so that setters and getters are automatically generated for each attribute in class. This saves time writing out the code for individual setters and getters for all attributes

    'Constructor
    Public Sub New(ByVal iUsername As String)
        'Constructor takes a string as an argument
        Username = iUsername.ToLower
        '.ToLower is used here so that any upper case letters typed in by the user are changed to lower case
    End Sub

    Public Sub setDetails(ByVal iForename As String, ByVal iSurname As String, ByVal iPassword As String, ByVal iDob As Date, ByVal iGender As String, ByVal iWeight As Double, ByVal iHeight As Double, ByVal iBfp As Double, ByVal iPal As Double, ByVal iGoal As Integer)
        'setDetails takes 3 strings, 1 date, 4 doubles and 1 integer as arguments
        Forename = iForename
        Surname = iSurname
        Password = iPassword
        DOB = iDob
        Gender = iGender
        Weight = iWeight
        Height = iHeight
        BFP = iBfp
        PAL = iPal
        Goal = iGoal
        mCals = (370 + (21.6 * (100 - BFP) * Weight * 0.01)) * PAL
        'Katch-McArdle equation
        Cals = mCals + (200 * Goal)

        If Goal = -1 Then
            Carbs = (Cals * 0.3) / 4
            Fats = (Cals * 0.3) / 9
            Proteins = (Cals * 0.4) / 4
        ElseIf Goal = 0 Then
            Carbs = (Cals * 0.4) / 4
            Fats = (Cals * 0.3) / 9
            Proteins = (Cals * 0.3) / 4
        ElseIf Goal = 1 Then
            Carbs = (Cals * 0.45) / 4
            Fats = (Cals * 0.2) / 9
            Proteins = (Cals * 0.35) / 4
        End If
        'Different proportions of carbs, fats and proteins depending on if the user wants to gain/maintain/lose weight
    End Sub

    Public Sub getDetails()
        tblStudent.getDetails(Me)
        'Calls public shared subroutine getDetails from TblStudent class, with current instance as a parameter
    End Sub

    Public Sub updateDetails()
        mCals = (370 + (21.6 * (100 - BFP) * Weight * 0.01)) * PAL
        'Katch-McArdle equation
        Cals = mCals + (200 * Goal)

        If Goal = -1 Then
            Carbs = (Cals * 0.3) / 4
            Fats = (Cals * 0.3) / 9
            Proteins = (Cals * 0.4) / 4
        ElseIf Goal = 0 Then
            Carbs = (Cals * 0.4) / 4
            Fats = (Cals * 0.3) / 9
            Proteins = (Cals * 0.3) / 4
        ElseIf Goal = 1 Then
            Carbs = (Cals * 0.45) / 4
            Fats = (Cals * 0.2) / 9
            Proteins = (Cals * 0.35) / 4
        End If
        'Different proportions of carbs, fats and proteins depending on if the user wants to gain/maintain/lose weight

        TblStudent.updateStudent(Me)
        'Calls public shared subroutine updateStudent from TblStudent class, with current instance (with changes) as a parameter
    End Sub

    Public Function addStudentToTable() As Boolean
        Return TblStudent.addToTable(Me)
        'Calls public shared function addToTable from TblStudent class, with current instance as a parameter and returns the return value of addToTable
    End Function

    Public Sub updatePassword()
        TblStudent.updatePassword(Me)
        'Calls public shared subroutine updatePassword from TblStudent class, with current instance as a parameter
    End Sub

    Public Sub deleteUser()
        TblStudent.deleteStudent(Me)
        'Calls public shared subroutine deleteStudent from TblStudent class, with current instance as a parameter
    End Sub
End Class
