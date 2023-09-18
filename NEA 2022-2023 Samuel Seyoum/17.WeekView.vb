Public Class WeekView

    Dim user As Student
    Dim admin As Boolean
    Dim lower, upper As Date
    'Created the local variables user (Student), admin (boolean) and lower and upper (date)

    'Constructor
    Public Sub New(ByVal iUser As Student, ByVal inputAdmin As Boolean)
        'Constructor takes a Student and a boolean as arguments

        InitializeComponent()
        'Visual Basic built in constructor for forms

        user = iUser
        admin = inputAdmin
        'Constructor takes values into local variables to be used in getting student's week and passed into new forms

        If CInt(DateTime.Today.DayOfWeek) = 0 Then
            upper = DateTime.Today
            lower = DateTime.Today.AddDays(-6)
        Else
            lower = DateTime.Today.AddDays(1 - CInt(DateTime.Today.DayOfWeek))
            upper = DateTime.Today.AddDays(7 - CInt(DateTime.Today.DayOfWeek))
        End If
        'Makes lower the Monday of the current week and makes upper the following Sunday
    End Sub

    'Updates the labels and graph 
    Private Sub updateForm()
        chrtWeek.Series.Clear()
        'Start with a fresh chart

        chrtWeek.Series.Add("Cals")

        chrtWeek.Series("Cals").XValueType = DataVisualization.Charting.ChartValueType.Date
        chrtWeek.Series("Cals").YValueType = DataVisualization.Charting.ChartValueType.Double
        'Sets the datatypes od the axis to date (x) and double (y)

        Dim studentDay As StudentDay
        'Creates local variable studentDay

        Dim cals As Double = 0
        Dim carbs As Double = 0
        Dim fats As Double = 0
        Dim proteins As Double = 0
        'Initialises values of macros before for loop

        For i = 0 To 6
            studentDay = New StudentDay(user, lower.AddDays(i))
            'Cycles through all 7 days in week
            'Get the cals, carbs, fats and protiens eaten by a student on the given day by instantiating StudentDay

            cals += studentDay.Cals
            carbs += studentDay.Carbs
            fats += studentDay.Fats
            proteins += studentDay.Proteins
            'Adds the cals, carbs, fats and protiens to the values already stored

            chrtWeek.Series("Cals").Points.AddXY(studentDay.eDate, studentDay.Cals)
            'Adds the cals eaten by the student in the day to the graph
        Next

        lblCals.Text = "Average cals: " & cals / 7 & " / " & user.Cals & " cals"
        lblCarbs.Text = "Average carbs: " & carbs / 7 & " / " & user.Carbs & " g"
        lblFats.Text = "Average fats: " & fats / 7 & " / " & user.Fats & " g"
        lblProtein.Text = "Average proteins: " & proteins / 7 & " / " & user.Proteins & " g"
        'Puts the average cals carbs, fats and proteins by dividing the totals by 7 alongside the corresponding recommended values for the user
    End Sub

    'When the form loads
    Private Sub WeekView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Text = user.Username
        'Make the text at the top of the form the username of the user specified

        lblDate.Text = (lower.ToShortDateString & " - " & upper.ToShortDateString)
        'Display the range of dates for the week

        updateForm()
        'Update the labels and graph
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fViewHistory As New ViewHistory(user, admin)
        'Instantiate ViewHistory form, passing user and admin as parameters to the constructor

        Me.Hide()
        fViewHistory.Show()
        'Open instantiated ViewHistory form
    End Sub

    'When btnNext is clicked
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        lower = lower.AddDays(7)
        upper = upper.AddDays(7)
        'Move to the next week by adding 7 days to both dates

        lblDate.Text = (lower.Date.ToShortDateString & " - " & upper.Date.ToShortDateString)
        'Display the range of dates for the new week

        updateForm()
        'Update the labels and graph
    End Sub

    'When btnPrev is clicked
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        lower = lower.AddDays(-7)
        upper = upper.AddDays(-7)
        'Move to the previeous week by taking 7 days from both dates

        lblDate.Text = (lower.ToShortDateString & " - " & upper.ToShortDateString)
        'Display the range of dates for the new week

        updateForm()
        'Update the labels and graph
    End Sub
End Class