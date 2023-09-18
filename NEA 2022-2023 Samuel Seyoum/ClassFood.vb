Public Class Food

    Public Property FoodID As Integer 'Unique ID of food
    Public Property Name As String 'Name of food
    Public Property Cals As Double 'Calories per 100g of food
    Public Property Carbs As Double 'Carbs per 100g of food
    Public Property Fats As Double 'Fats per 100g of food
    Public Property Proteins As Double 'Proteins per 100g of food
    Public Property Serve As Double 'Grams per serve of food
    'Public properties used so that setters and getters are automatically generated for each attribute in class. This saves time writing out the code for individual setters and getters for all attributes

    'Constructor
    Public Sub New(ByVal iFoodID As Integer)
        'Constructor takes an integer as an argument
        FoodID = iFoodID

        tblFood.getFood(Me)
        'Calls public shared subroutine getFood from tblFood class, with current instance as a parameter
    End Sub
End Class
