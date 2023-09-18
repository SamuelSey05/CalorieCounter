Public Class CustomFoodLog


    Dim user As Student
    'Creates local varaiable user (Student)

    Public Sub New(ByVal iUser As Student)
        'Takes a Student as an argument

        InitializeComponent()
        'Visual Basic built in constructor for forms

        user = iUser
        'Constructor takes value into local variable to be passed into new forms
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fFoodLog As New FoodLog(user)
        'Instantiate FoodLog passing user as a parameter to the constructor

        Me.Hide()
        fFoodLog.Show()
        'Open instantiated FoodLog form
    End Sub

    'When btnNewFood is clicked
    Private Sub btnNewFood_Click(sender As Object, e As EventArgs) Handles btnNewFood.Click
        Dim fAddCustomFoods As New AddCustomFoods(user)
        'Instantiate AddCustomFoods form, passing user as a parameter to the constructor

        Me.Hide()
        fAddCustomFoods.Show()
        'Open instantiated AddCustomFoods form
    End Sub

    'When the text in txtbxFoods is changed
    Private Sub txtbxFoods_TextChanged(sender As Object, e As EventArgs) Handles txtbxFoods.TextChanged
        dgvFoods.DataSource = TblCustomFood.searchCustomFood(txtbxFoods.Text, user)
        'Refresh the DataGridView with custom foods that have names that contain the new contents of txtbxFoods
    End Sub

    'When a cell is clicked in dgvFoods
    Private Sub dgvFoods_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFoods.CellContentClick
        Dim fFoodLog2 As New FoodLog2(user, dgvFoods.CurrentRow.Cells(0).Value, 1)
        'Instantiate FoodLog2 form passing user, CFoodID of selected food and 1 (to show that the food is  custom) as parameters to the constructor

        fFoodLog2.ShowDialog()
        'Open instantiated FoodLog2 form in front of current form
    End Sub
End Class