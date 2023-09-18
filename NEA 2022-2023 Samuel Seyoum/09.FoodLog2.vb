Public Class FoodLog2

    Private user As Student
    Private foodId, custom As Integer
    Private cals, carbs, fats, proteins, serve As Double
    'Create local variables user (Student), foodId and custom (integer) and cals, carbs, fats, proteins and serve (double)

    'Constructor
    Public Sub New(ByVal iUser As Student, ByVal inputFoodID As Integer, ByVal inputCustom As Integer)
        'Takes a Student and 2 integers as arguments

        InitializeComponent()
        'Visual Basic built in constructor for forms

        user = iUser
        foodId = inputFoodID
        custom = inputCustom
        'Constructor takes values into local variables to be used in adding food entry
    End Sub

    'Gets the details about the food inputted
    Private Sub getFoods()
        If custom = 1 Then
            Dim selectedFood As New CustomFood(foodId, user.Username)
            'Instantiate CustomFood passing foodId and username as parameters to the constructor and storing the result in selectedFood

            lblTitle.Text = selectedFood.Name
            'Make the title of the form the name of the custom food
            cals = selectedFood.Cals
            carbs = selectedFood.Carbs
            fats = selectedFood.Fats
            proteins = selectedFood.Proteins
            serve = selectedFood.Serve
            'Store the details of the custom food in the corresponding local variables
        Else
            Dim selectedFood As New Food(foodId)
            'Instantiate Food passing foodId as a parametere to the constructor and storing the result in selectedFood

            lblTitle.Text = selectedFood.Name
            'Make the title of the form the name of the food
            cals = selectedFood.Cals
            carbs = selectedFood.Carbs
            fats = selectedFood.Fats
            proteins = selectedFood.Proteins
            serve = selectedFood.Serve
            'Store the details of the food in the corresponding local variables
        End If
    End Sub

    'Logs the food entry in the datbase
    Private Sub logFood()
        Dim val As Integer
        'Creates the local variable val (integer)

        If rbtnBreakfast.Checked Then
            val = 1
            'If the radio button associated with breakfast is checked, set val to 1
        ElseIf rbtnMorning.Checked Then
            val = 2
            'If the radio button associated with morning snack is checked, set val to 2
        ElseIf rbtnLunch.Checked Then
            val = 3
            'If the radio button associated with lunch is checked, set val to 3
        ElseIf rbtnAfternoon.Checked Then
            val = 4
            'If the radio button associated with afternoon snack is checked, set val to 4
        ElseIf rbtnDinner.Checked Then
            val = 5
            'If the radio button associated with dinner is checked, set val to 5
        ElseIf rbtnEvening.Checked Then
            val = 6
            'If the radio button associated with evening snack is checked, set val to 6
        End If

        Dim foodEntry As New FoodEntry(user, dtpDate.Value, val, foodId, custom)
        'Instantiate FoodEntry, passing in user, date, val, foodId and custom as parameters to the constructor
        foodEntry.Amount = CDbl(txtbxGrams.Text)
        'Set the amount to the number of grams logged

        foodEntry.logFoodEntry()
        'Add the food entry to the database
    End Sub

    'When the form loads
    Private Sub FoodLog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getFoods()
        'Get the details of the food specified
    End Sub

    'Update the labels showing the macros of the food to be logged
    Private Sub updateLabels(ByVal grams As Double)
        'Takes a double as an argument

        lblCals.Text = grams * cals / 100 & " cals"
        lblCarbs.Text = grams * carbs / 100 & " g"
        lblFats.Text = grams * fats / 100 & " g"
        lblProteins.Text = grams * proteins / 100 & " g"
        'Update the labels with the new amounts of cals, carbs, fats and protiens 
    End Sub

    'When btnCancel is clicked
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Hide()
        'Close this form
        'No form needs to be opened because this form only appears in front of other forms
    End Sub

    'When btnLog is clicked
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        lblEmpty.Visible = False
        lblDate.Visible = False
        'Make error messages invisible

        If txtbxServes.Text = "" Or txtbxGrams.Text = "" Or Not (rbtnBreakfast.Checked Or rbtnLunch.Checked Or rbtnDinner.Checked Or rbtnMorning.Checked Or rbtnAfternoon.Checked Or rbtnEvening.Checked) Then
            lblEmpty.Visible = True
            'If either of the textboxes are empty, or none of the radio buttons are checked, show the empty error message
        ElseIf (dtpDate.Value - DateTime.Today).Days > 0 Then
            lblVDate.Visible = True
            'If the date occurs in the future, show the valid date error message
        ElseIf IsNumeric(txtbxServes.Text) And IsNumeric(txtbxGrams.Text) Then
            logFood()
            'If both txtbxServes and txtbxGrams have values that are numeric, log the food entry

            Me.Hide()
            'Close this form
            'No form needs to be opened because this form only appears in front of other forms
        End If
    End Sub

    'When the text in txtbxServes is changed by a keystroke
    Private Sub txtbxServes_KeyUp(sender As Object, e As EventArgs) Handles txtbxServes.KeyUp
        lblVAmount.Visible = False
        'Make the error message invisible

        If txtbxServes.Text = "" Then
            txtbxGrams.Text = ""
            'If txtbxServes is empty, make txtbxGrams empty
            updateLabels(0)
            'Update the labels with no food (all 0s)
        ElseIf IsNumeric(txtbxServes.Text) Then
            txtbxGrams.Text = CDbl(txtbxServes.Text) * serve
            'If the value in txtbxServes is numeric, make txtbxGrams contain the corresponding number of grams
            updateLabels(CDbl(txtbxGrams.Text))
            'Update the labels with the entered amount of food
        Else
            lblVAmount.Visible = True
            'If the value in txtbxServes is not empty or numeric, show the valid amount error message
        End If
    End Sub

    'When the text in txtbxServes is changed by a keystroke
    Private Sub txtbxGrams_KeyUp(sender As Object, e As EventArgs) Handles txtbxGrams.KeyUp
        lblVAmount.Visible = False
        'Make the error message invisible

        If txtbxGrams.Text = "" Then
            txtbxServes.Text = ""
            'If txtbxGramss is empty, make txtbxServes empty
            updateLabels(0)
            'Update the labels with no food (all 0s)
        ElseIf IsNumeric(txtbxGrams.Text) Then
            txtbxServes.Text = CDbl(txtbxGrams.Text) / serve
            'If the value in txtbxGramss is numeric, make txtbxServess contain the corresponding number of serves
            updateLabels(CDbl(txtbxGrams.Text))
            'Update the labels with the entered amount of food
        Else
            lblVAmount.Visible = True
            'If the value in txtbxGrams is not empty or numeric, show the valid amount error message
        End If
    End Sub
End Class