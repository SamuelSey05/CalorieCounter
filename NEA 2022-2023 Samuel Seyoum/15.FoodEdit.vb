Public Class FoodEdit

    Dim foodEntry As FoodEntry
    'Creates local variable foodEntry (FoodEntry)

    'Constructor
    Public Sub New(ByVal iFoodEntry As FoodEntry)
        'Constructor takes  FoodEntry as an arguemetn

        InitializeComponent()
        'Visual Basic built in constructor for forms

        foodEntry = iFoodEntry
        'Constructor takes values into local variables to be passed into new forms
    End Sub

    'WHen btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        'Close this form
        'No form needs to be opened because this form only appears in front of other forms
    End Sub

    'When btnDelete is clicked
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If MsgBox("Click Ok to delete food", 1) = 1 Then
            'Use an OK/Cancel message box
            foodEntry.deleteFoodEntry()
            'If Ok is clicked on the messge box, delete food entry

            Me.Hide()
            'Close this form
            'No form needs to be opened because this form only appears in front of other forms
        End If
    End Sub

    'When btnEAmount is clicked
    Private Sub btnEAmount_Click(sender As Object, e As EventArgs) Handles btnEAmount.Click
        Dim fFoodEdit2 As New FoodEdit2(foodEntry)
        'Instantiate FoodEdit2 form, passing foodEntry as a parameter to the constructor

        Me.Hide()
        fFoodEdit2.ShowDialog()
        'Open intantiated FoodEdit2 form in front of open form
    End Sub
End Class