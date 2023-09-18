Public Class AddCustomFoods

    Dim user As Student
    'Creates local variable user (Student)

    'Constructor
    Public Sub New(ByVal iUser As Student)
        'Takes a Student as an argument

        InitializeComponent()
        'Visual Basic built in constructor for forms

        user = iUser
        'Constructor takes value into local variable to be used when adding custom food or to be passed into new forms
    End Sub

    'This function adds a value to tblCustomFoods
    Private Function addCustomFood()
        Return TblCustomFood.addCustomFood(user, txtbxName.Text, lblCals.Text * 100 / txtbxServe.Text, txtbxCarbs.Text * 100 / txtbxServe.Text, txtbxFats.Text * 100 / txtbxServe.Text, txtbxProteins.Text * 100 / txtbxServe.Text, txtbxServe.Text)
        'Call the public shared function TblCustomFood.addCustomFood with parameters user, name, cals, carbs, fats, proteins and serve and return the result
    End Function

    'Sums the calories in the custom food
    Private Function sumMacros()
        Dim carbs, fats, proteins As Double

        If txtbxCarbs.Text = "" Then
            carbs = 0
        Else
            carbs = CDbl(txtbxCarbs.Text)
        End If

        If txtbxFats.Text = "" Then
            fats = 0
        Else
            fats = CDbl(txtbxFats.Text)
        End If

        If txtbxProteins.Text = "" Then
            proteins = 0
        Else
            proteins = CDbl(txtbxProteins.Text)
        End If
        'If the textboxes are empty, they still cause IsNumeric to be True so we must handle this exception separately

        Return (carbs * 4) + (fats * 9) + (proteins * 4)
        'Sums the calories from carbs (4 cal/g), fats (9 cal/g) and proteins (4 cal/g) and returns the result
    End Function

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fCustomFoodLog As New CustomFoodLog(user)
        'Instantiate CustomFoodLog form, passing user as a parameter to the constructor

        Me.Hide()
        fCustomFoodLog.Show()
        'Open instantiated CustomFoodLog form
    End Sub

    'When the text in txtbxCarbs is changed
    Private Sub txtbxCarbs_TextChanged(sender As Object, e As EventArgs) Handles txtbxCarbs.TextChanged
        lblVCarbs.Visible = False
        'Make the error messgage invisible

        If IsNumeric(txtbxCarbs.Text) Then
            lblCals.Text = sumMacros()
            'If the new value in txtbxCarbs is numeric, update the calories label
        Else
            lblVCarbs.Visible = True
            'If the new value in txtbxFats is not numeric, show the valid carbs error messsage
        End If
    End Sub

    'When the text in txtbxFats is changed
    Private Sub txtbxFats_TextChanged(sender As Object, e As EventArgs) Handles txtbxFats.TextChanged
        lblVFats.Visible = False
        'Make the error messgage invisible

        If IsNumeric(txtbxFats.Text) Then
            lblCals.Text = sumMacros()
            'If the new value in txtbxFats is numeric, update the calories label
        Else
            lblVFats.Visible = True
            'If the new value in txtbxFats is not numeric, show the valid carbs error messsage
        End If
    End Sub

    'When the text in txtbxProteins is changed
    Private Sub txtbxProteins_TextChanged(sender As Object, e As EventArgs) Handles txtbxProteins.TextChanged
        lblVProteins.Visible = False
        'Make the error messgage invisible

        If IsNumeric(txtbxProteins.Text) Then
            lblCals.Text = sumMacros()
            'If the new value in txtbxProteins is numeric, update the calories label
        Else
            lblVProteins.Visible = True
            'If the new value in txtbxProteins is not numeric, show the valid carbs error messsage
        End If
    End Sub

    'When btnCreate is clicked
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        lblEmpty.Visible = False
        'Make the error message invisible

        If txtbxName.Text = "" Or txtbxCarbs.Text = "" Or txtbxFats.Text = "" Or txtbxProteins.Text = "" Or txtbxServe.Text = "" Then
            lblEmpty.Visible = True
            'If any of the textboxes are empty, show the empty error message
        Else
            Dim newCFoodID As Integer = addCustomFood()
            'Add the custom food to the database and return the CFoodID to newCFoodID
            If newCFoodID <> -1 Then
                Dim fFoodLog2 As New FoodLog2(user, newCFoodID, 1)
                'If newCFoodID is not -1 (only returned if there was an error adding the custom food to the database), instantiate FoodLog2 form, passing user, CFoodID of created custom food and 1 (to show that the food is custom) as parameters to the constructor

                fFoodLog2.ShowDialog()
                'Open instantiated FoodLog2 form in front of the current form
            End If
        End If
    End Sub
End Class