Public Class AGroupView2

    Dim time, count As Integer
    Dim lower, upper As Date
    Dim cals, carbs, fats, proteins As Double
    Dim years As New List(Of Boolean)
    'Creates local variables time and count (integer), lower and upper (date), cals, carbs, fats and proteins (double) and years (list of boolean)

    'Constructor
    Public Sub New(Itime As Integer, Ifirst As Boolean, Isecond As Boolean, Ithird As Boolean, Ifourth As Boolean, Ififth As Boolean, ILsixth As Boolean, IUsixth As Boolean)
        'Constructor takes an integer and 7 booleans as arguments

        InitializeComponent()
        'Visual Basic built in constructor for forms

        time = Itime
        years.Add(Ifirst)
        years.Add(Isecond)
        years.Add(Ithird)
        years.Add(Ifourth)
        years.Add(Ififth)
        years.Add(ILsixth)
        years.Add(IUsixth)
        'Constructor takes value into local variables to be used in displaying food data
    End Sub

    'Returns the amount of calories eaten by a year group in a given timespan while adding the macros to the totals
    Private Function addYearPoint(ByVal form As Integer, ByRef count As Integer, ByRef cals As Double, ByRef carbs As Double, ByRef fats As Double, ByRef proteins As Double) As Double
        'Takes 2 integers and 4 doubles as arguments
        'Returns a double
        Dim yearSpan As New YearSpan(22 - form, lower, upper)
        'Instantiates YearSpan, passing in prefix, lower and upper as parameters to the constructor

        cals += yearSpan.Cals
        carbs += yearSpan.Carbs
        fats += yearSpan.Fats
        proteins += yearSpan.Proteins
        count += yearSpan.Count
        'Add the totals of cals, carbs, fats, proteins and students in that year group that logged food in that timespan to totals

        Return yearSpan.Cals / yearSpan.Count
        'Return the average calories eaten per person that logged a food in the timespan specified
    End Function

    'Adds points to the graph when the form is in day or week mode
    Private Sub addDayPoint(ByVal day As Date, ByRef count As Integer, ByRef cals As Double, ByRef carbs As Double, ByRef fats As Double, ByRef proteins As Double)
        'Takes a date, an integer and 4 doubles as arguments
        Dim yearDay As YearSpan

        Dim dayCals As Double = 0
        Dim dayCount As Integer = 0
        'Creates local variables dayCals, dayCount and yearDay to be used in the for loop

        For i = 0 To 6
            'Cycle through the year groups
            If years(i) Then
                yearDay = New YearSpan(22 - i, day, day)
                'If the year group was selected in the previous form, instantiate YearSpan and put the value in yearDay

                dayCals += yearDay.Cals
                carbs += yearDay.Carbs
                fats += yearDay.Fats
                proteins += yearDay.Proteins
                dayCount += yearDay.Count
                'Add the totals of cals, carbs, fats, proteins and students in that year group that logged food on the day to totals
            End If
        Next

        cals += dayCals
        count += dayCount
        'Increment the values of cals and count with the totals added in the for loop
        'The reason cals and count are added separately is because the values are needed to add the point to the chart

        chrtView.Series("Days").Points.AddXY(day.ToShortDateString, dayCals / dayCount)
        'Add average calories eaten by students that logged a food on a day with that day as a point on the chart
    End Sub

    'Updates the graph and labels when the form is in day mode
    Private Sub Day()
        chrtView.Series.Add("Day")

        chrtView.Series("Day").XValueType = DataVisualization.Charting.ChartValueType.String
        chrtView.Series("Day").YValueType = DataVisualization.Charting.ChartValueType.Double
        'Set the datatypes of the axis to string (x) and double (y)

        count = 0
        cals = 0
        carbs = 0
        fats = 0
        proteins = 0
        'Initialise values of macros and count

        If years(0) Then
            chrtView.Series("Day").Points.AddXY("1st Form", addYearPoint(0, count, cals, carbs, fats, proteins))
        End If

        If years(1) Then
            chrtView.Series("Day").Points.AddXY("2nd Form", addYearPoint(1, count, cals, carbs, fats, proteins))
        End If

        If years(2) Then
            chrtView.Series("Day").Points.AddXY("3rd Form", addYearPoint(2, count, cals, carbs, fats, proteins))
        End If

        If years(3) Then
            chrtView.Series("Day").Points.AddXY("4th Form", addYearPoint(3, count, cals, carbs, fats, proteins))
        End If

        If years(4) Then
            chrtView.Series("Day").Points.AddXY("5th Form", addYearPoint(4, count, cals, carbs, fats, proteins))
        End If

        If years(5) Then
            chrtView.Series("Day").Points.AddXY("L6th Form", addYearPoint(5, count, cals, carbs, fats, proteins))
        End If

        If years(6) Then
            chrtView.Series("Day").Points.AddXY("U6th Form", addYearPoint(6, count, cals, carbs, fats, proteins))
        End If

        'If the corresponding value in the years list is true, call addYearPoint for that year group so that cals, carbs, fats, proteins and count accumulate sums of all the corresponding values

        lblCals.Text = "Average cals: " & (cals / count)
        lblCarbs.Text = "Average carbs: " & (carbs / count)
        lblFats.Text = "Average fats: " & (fats / count)
        lblProtein.Text = "Average proteins: " & (proteins / count)
        'Show the average cals, carbs, fats and proteins in the corresponding labels
    End Sub

    'Updates the graph and labels when form is in week or month mode
    Private Sub LongTime()
        chrtView.Series.Add("Days")

        chrtView.Series("Days").XValueType = DataVisualization.Charting.ChartValueType.Date
        chrtView.Series("Days").YValueType = DataVisualization.Charting.ChartValueType.Double
        'Set the datatypes of the axis to date (x) and double (y)

        count = 0
        cals = 0
        carbs = 0
        fats = 0
        proteins = 0
        'Initialise values of macros and count

        Dim i As Date = lower.AddDays(-1)
        'Start with lower date

        Do
            i = i.AddDays(1)
            'Go onto next day

            addDayPoint(i, count, cals, carbs, fats, proteins)
            'Add a point on the graph for day i as well as allow cals, carbs, fats, proteins and count to accumulate sums of all the corresponding values
        Loop Until i.Date = upper.Date
        'Loop through all days in timespan

        lblCals.Text = "Average cals: " & (cals / count)
        lblCarbs.Text = "Average carbs: " & (carbs / count)
        lblFats.Text = "Average fats: " & (fats / count)
        lblProtein.Text = "Average proteins: " & (proteins / count)
        'Show the average cals, carbs, fats and proteins in the corresponding labels
    End Sub

    'When the form loads
    Private Sub GroupView2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chrtView.Series.Clear()
        'Start with an empty graph

        Select Case time
            Case 1
                MyBase.Text = "Day view"
                lower = DateTime.Today
                upper = DateTime.Today
                'Set lower and upper to current date
                lblTime.Text = lower.ToShortDateString
                'Show date specified in label
                Day()
                'Update graph and labels
            Case 2
                MyBase.Text = "Week view"
                If CInt(DateTime.Today.DayOfWeek) = 0 Then
                    upper = DateTime.Today
                    lower = DateTime.Today.AddDays(-6)
                Else
                    lower = DateTime.Today.AddDays(1 - CInt(DateTime.Today.DayOfWeek))
                    upper = DateTime.Today.AddDays(7 - CInt(DateTime.Today.DayOfWeek))
                End If
                'Make lower Monday of current week and upper the following Sunday
                lblTime.Text = lower.ToShortDateString & " - " & upper.ToShortDateString
                'Show timespan in label
                LongTime()
                'Update graph and labels
            Case 3
                MyBase.Text = "Month view"
                lower = CDate("1/" & DateTime.Today.Month & "/" & DateTime.Today.Year)
                upper = CDate(DateTime.DaysInMonth(lower.Year, lower.Month) & "/" & lower.Month & "/" & lower.Year)
                'Make lower 1st of current month and make upper last day of current month
                lblTime.Text = lower.ToShortDateString & " - " & upper.ToShortDateString
                'Show timespan in label
                LongTime()
                'Update graph and labels
        End Select
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fGroupView As New AGroupView
        'Instantiate GroupView form

        Me.Hide()
        fGroupView.Show()
        'Open instantiated GroupView form
    End Sub

    'When btnNext is clicked
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        chrtView.Series.Clear()
        'Start with an empty graph

        Select Case time
            Case 1
                lower = lower.AddDays(1)
                upper = upper.AddDays(1)
                'Move to next day by adding 1 day to lower and upper
                lblTime.Text = lower.ToShortDateString
                'Show date specified in label
                Day()
                'Update graph and labels
            Case 2
                lower = lower.AddDays(7)
                upper = upper.AddDays(7)
                'Move to next week by adding 7 days to lower and upper
                lblTime.Text = lower.ToShortDateString & " - " & upper.ToShortDateString
                'Show timespan in label
                LongTime()
                'Update graph and labels
            Case 3
                lower = upper.AddDays(1)
                upper = CDate(DateTime.DaysInMonth(lower.Year, lower.Month) & "/" & lower.Month & "/" & lower.Year)
                'Make lower 1st of following month and upper last day of following month
                lblTime.Text = lower.ToShortDateString & " - " & upper.ToShortDateString
                'Show timespan in label
                LongTime()
                'Update graph and labels
        End Select
    End Sub

    'When btnPrev is clicked
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        chrtView.Series.Clear()
        'Start with an empty graph

        Select Case time
            Case 1
                lower = lower.AddDays(-1)
                upper = upper.AddDays(-1)
                'Move to previous day by taking 1 day from lower and upper
                lblTime.Text = lower.ToShortDateString
                'Show date specified in label
                Day()
                'Update graph and labels
            Case 2
                lower = lower.AddDays(-7)
                upper = upper.AddDays(-7)
                'Move to previous week by taking 7 days from lower and upper
                lblTime.Text = lower.ToShortDateString & " - " & upper.ToShortDateString
                'Show timespan in label
                LongTime()
                'Update graph and labels
            Case 3
                upper = lower.AddDays(-1)
                lower = CDate("1/" & upper.Month & "/" & upper.Year)
                'Make upper last day of previous month and make lower first day of previous month
                lblTime.Text = lower.ToShortDateString & " - " & upper.ToShortDateString
                'Show timespan in label
                LongTime()
                'Update graph and labels
        End Select
    End Sub
End Class