Public Class StudentDay
    Public Property User As Student 'User specified
    Public Property eDate As Date 'Date specified
    Public Property Cals As Double 'Calories eaten by specified user on specified day
    Public Property Carbs As Double 'Carbs eaten by specified user on specified day
    Public Property Fats As Double 'Fats eaten by specified user on specified day
    Public Property Proteins As Double 'Proteins eaten by specified user on specified day
    'Public properties used so that setters and getters are automatically generated for each attribute in class. This saves time writing out the code for individual setters and getters for all attributes

    'Constructor
    Public Sub New(ByVal iUser As Student, ByVal iDate As Date)
        'Constructor takes an initialised Student and a date as arguments

        User = iUser
        eDate = iDate
        Cals = 0
        Carbs = 0
        Fats = 0
        Proteins = 0

        TblFoodEntry.getStudentDay(Me)
        'Calls public shared subroutine getStudentDay from TblFoodEntry Class, passing in the current instance as a parameter
    End Sub
End Class
