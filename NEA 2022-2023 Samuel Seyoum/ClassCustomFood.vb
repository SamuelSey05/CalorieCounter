Public Class CustomFood
    Public Property FoodID As Integer 'ID of custom food
    Public Property Username As String 'Username of user that custom food belons to 
    Public Property Name As String 'Name of custom food
    Public Property Cals As Double 'Calories per 100g of custom food
    Public Property Carbs As Double 'Carbs per 100g of custom food
    Public Property Fats As Double 'Fats per 100g of custom food
    Public Property Proteins As Double 'Proteins per 100g of custom food
    Public Property Serve As Double 'Grams per serving of cutsom food
    'Public properties used so that setters and getters are automatically generated for each attribute in class. This saves time writing out the code for individual setters and getters for all attributes

    'Constructor
    Public Sub New(ByVal iFoodID As Integer, ByVal iUsername As String)
        'Constructor takes integer and string as arguments
        FoodID = iFoodID
        Username = iUsername

        TblCustomFood.getCustomFood(Me)
        'Calls public shared subroutine getCustomFood from TblCustomFood class
    End Sub
End Class
