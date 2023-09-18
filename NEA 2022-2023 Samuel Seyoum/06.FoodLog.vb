Public Class FoodLog

    Dim user As Student
    'Creates local variable user (Student)

    'Constructor
    Public Sub New(ByVal iUser As Student)
        'Takes a Student as an argument

        InitializeComponent()
        'Visual Basic built in constructor for forms

        user = iUser
        'Constructor takes value into local variable to be passed into new forms
    End Sub

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fSMainMenu As New SMainMenu(user)
        'Instantiate SMainMenu form passing user as a parameter to the constructor

        Me.Hide()
        fSMainMenu.Show()
        'Open instantiated SMainMenu form
    End Sub

    'When btnCustomFood is clicked
    Private Sub btnCustomFood_Click(sender As Object, e As EventArgs) Handles btnCustomFood.Click
        Dim fCUstomFood As New CustomFoodLog(user)
        'Instantiate CustomFoodLog form, passing user as a parameter to the constructor

        Me.Hide()
        fCUstomFood.Show()
        'Open instantiated CustomFoodLog form
    End Sub

    'When the text in txtbxFoods is changed
    Private Sub txtbxFoods_TextChanged(sender As Object, e As EventArgs) Handles txtbxFoods.TextChanged
        dgvFoods.DataSource = TblFood.searchFood(txtbxFoods.Text)
        'Refresh the DataGridView with foods that have names that contain the new contents of txtbxFoods
    End Sub

    'When a cell is clicked in dgvFoods
    Private Sub dgvFoods_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFoods.CellContentClick
        Dim fFoodLog2 As New FoodLog2(user, dgvFoods.CurrentRow.Cells(0).Value, 0)
        'Instantiate FoodLog2 form, passing user, FoodID of selected food and 0 (to show that the food is not custom) as parameters to the constructor

        fFoodLog2.ShowDialog()
        'Open instantiated FoodLog2 form in front of current form
    End Sub
End Class