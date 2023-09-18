Public Class ViewHistory

    Dim user As Student
    Dim admin As Boolean
    'Creates local variables user (Student) and admin (boolean)

    'Constructor
    Public Sub New(ByVal iUser As Student, ByVal inputAdmin As Boolean)
        'Constructor takes a Student and a boolean as arguments

        InitializeComponent()
        'Visual Basic built in constructor for forms

        user = iUser
        admin = inputAdmin
        'Constructor takes values into local variables to be passed into new forms
    End Sub

    'When the form loads
    Private Sub ViewHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Text = user.Username
        'Make the text at the top of the form the username of the specified user
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If admin Then
            Dim fAStudentView As New AStudentView
            'If an admin opened this form, instantiate AStudentView form

            Me.Hide()
            fAStudentView.Show()
            'Open instantiated AStudentView form
        Else
            Dim fSMainMenu As New SMainMenu(user)
            'If a student opened this form, instantiate SMainMenu form, passing user as a paranter to the constructor

            Me.Hide()
            fSMainMenu.Show()
            'Open instantiated SMainMenu form
        End If
    End Sub

    'When btnVDay is clicked
    Private Sub btnVDay_Click(sender As Object, e As EventArgs)
        Dim fDayView As New DayView(user, admin)
        'Instantiate DayView form, passing user and admin as parameters to the constructor

        Me.Hide()
        fDayView.Show()
        'Open instantiatad DayView form
    End Sub

    Private Sub btnVWeek_Click(sender As Object, e As EventArgs) Handles btnVWeek.Click
        Dim fWeekView As New WeekView(user, admin)
        'Instantiate WeekView form, passing user and admin as parameters to the constructor

        Me.Hide()
        fWeekView.Show()
        'Open instantiated WeekView form
    End Sub
End Class