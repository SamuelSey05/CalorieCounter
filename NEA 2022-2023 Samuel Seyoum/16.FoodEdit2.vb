Public Class FoodEdit2

    Private cals, carbs, fats, proteins, serve As Double
    Dim foodEntry As FoodEntry
    'Creaete local variables serves (double) and foodEntry (FoodEntry)

    'Constructor
    Public Sub New(ByVal ifoodEntry As FoodEntry)
        'Constructor takes a FoodEntry as an argument
        InitializeComponent()
        'Visual Basic built in constructor for forms

        foodEntry = ifoodEntry
        'Constructor takes values into local variables to be used in editing food entry
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

    'When form loads
    Private Sub FoodEdit2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If foodEntry.Custom = 1 Then
            Dim customFood As New CustomFood(foodEntry.FoodID, foodEntry.Username)
            'If the food in the food entry is custom, instantiate CustomFood, passing the CFoodID and the username as parameters to the constructor

            txtbxServes.Text = foodEntry.Amount / customFood.Serve
            txtbxGrams.Text = foodEntry.Amount
            cals = customFood.Cals
            carbs = customFood.Carbs
            fats = customFood.Fats
            proteins = customFood.Proteins
            serve = customFood.Serve
            serve = customFood.Serve
            Me.Text = customFood.Name
            'Store the details of the custom food in the corresponding local variables
        Else
            Dim food As New Food(foodEntry.FoodID)
            'If the food in the food entry is not custom, instantiate Food, passing the FoodID as a parameter to the constructor

            txtbxServes.Text = foodEntry.Amount / food.Serve
            txtbxGrams.Text = foodEntry.Amount
            cals = food.Cals
            carbs = food.Carbs
            fats = food.Fats
            proteins = food.Proteins
            serve = food.Serve
            Me.Text = food.Name
            'Store the details of the food in the corresponding local variables
        End If
        updateLabels(CDbl(txtbxGrams.Text))
        'Update the values in the labels representing macros
    End Sub

    'Whem btnLog is clicked
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        lblEmpty.Visible = False
        'Make error message invisible

        If txtbxGrams.Text = "" Or txtbxServes.Text = "" Then
            lblEmpty.Visible = True
            'If the textboxes are empty, show the empty error message
        ElseIf IsNumeric(txtbxServes.Text) And IsNumeric(txtbxGrams.Text) Then
            foodEntry.Amount = CDbl(txtbxGrams.Text)
            'If both txtbxServes and txtbxGrams have values that are numeric, update the amount in the food entry

            foodEntry.updateFoodEntry()
            'Update the food entry

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
            txtbxGrams.Text = CDec(txtbxServes.Text) * serve
            'If the value in txtbxServes is numeric, make txtbxGrams contain the corresponding number of grams
            updateLabels(CDec(txtbxGrams.Text))
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
            txtbxServes.Text = CDec(txtbxGrams.Text) / serve
            'If the value in txtbxGramss is numeric, make txtbxServess contain the corresponding number of serves
            updateLabels(CDec(txtbxGrams.Text))
            'Update the labels with the entered amount of food
        Else
            lblVAmount.Visible = True
            'If the value in txtbxGrams is not empty or numeric, show the valid amount error message
        End If
    End Sub
End Class