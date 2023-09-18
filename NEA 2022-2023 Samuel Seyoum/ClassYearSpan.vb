Public Class YearSpan

    Public Property Prefix As String 'First 2 characters of a students username are the year they joined the school, which corresponds to the year group they are in
    Public Property sDate As Date 'Start date of timespan specified
    Public Property eDate As Date 'End date of timespan specified
    Public Property Cals As Double 'Calories eaten in timespan specified by specified yeargroup
    Public Property Carbs As Double 'Carbs eaten in timespan specified by specified yeargroup
    Public Property Fats As Double 'Fats eaten in timespan specified by specified yeargroup
    Public Property Proteins As Double 'Proteins eaten in timespan specified by specified yeargroup
    Public Property Count As Integer 'Number of students in specified yeargroup that ate food in specified timespan
    'Public properties used so that setters and getters are automatically generated for each attribute in class. This saves time writing out the code for individual setters and getters for all attributes

    'Constructor
    Public Sub New(ByVal iPrefix As Integer, ByVal iSDate As Date, ByVal iEDate As Date)
        'Constructor takes integer and two dates as arguments

        Prefix = iPrefix.ToString
        '.ToString used as Prefix will be used as a varchar for the SQL query in TblFoodEntry.getYearSpan
        sDate = iSDate
        eDate = iEDate

        TblFoodEntry.getYearSpan(Me)
        'Calls public shared subroutine getYearSpan from TblFoodEntry Class, passing in the current instance as a parameter
    End Sub
End Class
