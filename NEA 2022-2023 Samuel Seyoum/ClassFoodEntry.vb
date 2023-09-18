Public Class FoodEntry

    Public Property Username As String 'Username of user who logged food entry 
    Public Property tDate As Date 'Date of food entry
    Public Property Time As Integer 'Time of food entry
    '1 - breakfast
    '2 - morning snack
    '3 - lunch
    '4 - afternoon snack
    '5 - dinner
    '6 - evening snack
    Public Property FoodID As Integer 'FoodID of food in food entry
    Public Property Custom As Integer 'Whether food entry is of a custom food or not
    '1 - Custom food
    '0 - Not custom food
    Public Property Amount As Double ' Amount of food in food entry in grams
    'Public properties used so that setters and getters are automatically generated for each attribute in class. This saves time writing out the code for individual setters and getters for all attributes

    'Constructor
    Public Sub New(ByVal iUser As Student, ByVal iTDate As Date, ByVal iTime As Integer, ByVal iFoodID As Integer, ByVal iCustom As Integer)
        'Constructor takes an instantiated student, a date and 3 integers as arguments
        Username = iUser.Username
        tDate = iTDate
        Time = iTime
        FoodID = iFoodID
        Custom = iCustom
    End Sub

    Public Sub logFoodEntry()
        TblFoodEntry.logFood(Me)
        'Calls public shared subroutine logFood from TblFoodEntry class, with current instance as a parameter
    End Sub

    Public Sub getFoodEntry()
        Amount = TblFoodEntry.getAmount(Me)
        'Calls public shared function getAmount from TblFoodEntry class, with current instance as a parameter and assigns the return value to amount
    End Sub

    Public Sub deleteFoodEntry()
        TblFoodEntry.deleteFoodEntry(Me)
        'Calls public shared subroutine deleteFoodEntry from TblFoodEntry class, with current instance as a parameter
    End Sub

    Public Sub updateFoodEntry()
        TblFoodEntry.updateAmount(Me)
        'Calls public shared subroutine updateAmount from TblFoodEntry class, with current instance as a parameter
    End Sub
End Class
