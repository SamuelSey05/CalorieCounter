Public Class DayView

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
        'Constructor takes values into local variables to be used in getting student day and passed into new forms
    End Sub

    'Gets the macros eaten by a user on a specific day and puts data into a doughnut chart
    Private Sub getStudentDay()
        Dim studentDay As New StudentDay(user, CDate(lblDate.Text))
        'Instantiate StudentDay, passing user and specified date as parameters to the constructor and storing the result in studentDay

        lblCals.Text = "Cals: " & studentDay.Cals & " / " & user.Cals & " cals"
        lblCarbs.Text = "Carbs: " & studentDay.Carbs & " / " & user.Carbs & " g"
        lblFats.Text = "Fats: " & studentDay.Fats & " / " & user.Fats & " g"
        lblProtein.Text = "Proteins: " & studentDay.Proteins & " / " & user.Proteins & " g"
        'Gets the cals, carbs, fats and proteins eaten by the student on that day and puts those values into the corresponding labels with the corresponding recommended values for the user

        Dim carbCals As Double = studentDay.Carbs * 4
        Dim fatCals As Double = studentDay.Fats * 9
        Dim proteinCals As Double = studentDay.Proteins * 4
        Dim remainingCals As Double = user.Cals - carbCals - fatCals - proteinCals
        'Create local variables for the amount of cals from carbs, fats and proteins and the remaining cals to be eaten in that day

        Dim yValues As Double() = {carbCals, fatCals, proteinCals, remainingCals}
        Dim xValues As String() = {"Carbs", "Fats", "Proteins", "Remaining"}

        chrtCals.Series.Clear()
        'Start with a fresh chart
        chrtCals.Series.Add("Cals")
        chrtCals.Series("Cals").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
        'Specifies that chart will be doughnut chart

        chrtCals.Series("Cals").Points.DataBindXY(xValues, yValues)
        'Add the values for cals from carbs, fats and proteins ans remaining cals to a doughnut chart

        chrtCals.Series("Cals").Points(0).Color = Color.Wheat
        chrtCals.Series("Cals").Points(1).Color = Color.Red
        chrtCals.Series("Cals").Points(2).Color = Color.Blue
        chrtCals.Series("Cals").Points(3).Color = Color.Gray
        'Gives different colours to Each category

        chrtCals.Legends(0).Enabled = True
        'Allows for a legend on the side of the chart
        chrtCals.Series("Cals").IsValueShownAsLabel = True
        'Shows the value for each category on the side
    End Sub

    'Update the DataGridView
    Private Sub updateDGV()
        dgvFoods.DataSource = TblFoodEntry.searchFoodEntry(txtbxFoods.Text, user, CDate(lblDate.Text))
        'Update the DataGridView by calling public shared function TblFoodEntry.searchFoodEntry, passing in parameters the text typed, user and specified date
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fViewHistory As New ViewHistory(user, admin)
        'Instantiate ViewHistory form, passing in user and admin as parameters to the constructor

        Me.Hide()
        fViewHistory.Show()
        'Open instantiated ViewHistory form
    End Sub

    'When form loads
    Private Sub DayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Text = user.Username
        'Make text at top of form username of specified user

        lblDate.Text = DateTime.Today.ToShortDateString
        'Make specified date current date
        updateDGV()
        getStudentDay()
        'Update DataGridView, labels and chart
    End Sub

    'When btnNext is clicked
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        lblDate.Text = CDate(lblDate.Text).AddDays(1).ToShortDateString
        'Add 1 day to the date
        updateDGV()
        getStudentDay()
        'Update DataGridView, labels and chart
    End Sub

    'WHen btnPrev is clicked
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        lblDate.Text = CDate(lblDate.Text).AddDays(-1).ToShortDateString
        'Take 1 day from the date
        updateDGV()
        getStudentDay()
        'Update DataGridView, labels and chart
    End Sub

    'When the text in txtbxFoods is changed
    Private Sub txtbxFoods_TextChanged(sender As Object, e As EventArgs) Handles txtbxFoods.TextChanged
        updateDGV()
        'Update DataGridView with food entries of foods that have names that contain new text in txtbxFoods
    End Sub

    'When a cell in dgvFoods is clicked
    Private Sub dgvFoods_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFoods.CellContentClick
        Dim foodEntry As New FoodEntry(user, CDate(lblDate.Text), dgvFoods.CurrentRow.Cells(3).Value, dgvFoods.CurrentRow.Cells(0).Value, dgvFoods.CurrentRow.Cells(4).Value)
        'Instantiate FoodEntry, passing user, date, time, foodID and custom as parameters to the constructor
        foodEntry.getFoodEntry()
        'Get the amount of the food entry

        Dim fFoodEdit As New FoodEdit(foodEntry)
        'Instantiate FoodEdit

        fFoodEdit.ShowDialog()
        'Open instantiated FoodEdit in front of current form

        updateDGV()
        getStudentDay()
        'Update DataGridView, labels and chart
    End Sub
End Class