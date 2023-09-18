Public Class SMainMenu

    Dim user As Student
    'Creates local variable user (Student)

    'Constructor
    Public Sub New(ByVal iUser As Student)
        'Takes a Student as an argument

        InitializeComponent()
        'Visual Basic built in constructor

        user = iUser
        'Construcor takes value into local variable to be passed into the next forms
    End Sub

    'When btnFoodLog is clicked
    Private Sub btnFoodLog_Click(sender As Object, e As EventArgs) Handles btnFoodLog.Click
        Dim fFoodLog As New FoodLog(user)
        'Instantiate FoodLog form, passing user as a parameter to the constructor

        Me.Hide()
        fFoodLog.Show()
        'Open instantiated FoodLog form
    End Sub

    'When btnUserEdit is clicked
    Private Sub btnUserEdit_Click(sender As Object, e As EventArgs) Handles btnUserEdit.Click
        Dim fUserEdit As New UserEdit(user)
        'Instantiate UserEdit form, passing user as a parameter to the constructor

        Me.Hide()
        fUserEdit.Show()
        'Open instantiated UserEdit form
    End Sub

    'When btnHistory is clicked
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim fViewHistory As New ViewHistory(user, False)
        'Instantiate ViewHistory form, passing user as a parameter to the constructor

        Me.Hide()
        fViewHistory.Show()
        'Open instantiated ViewHistory form
    End Sub

    'When btnLogOut is clicked
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MsgBox("Click Ok to log out", 1) = 1 Then
            'Use an OK/Cancel message box
            Dim fWelcome As New Welcome
            'If Ok is clicked on the messge box, instantiate Welcome form

            Me.Hide()
            fWelcome.Show()
            'Open instantiated Welcome form
        End If
    End Sub
End Class