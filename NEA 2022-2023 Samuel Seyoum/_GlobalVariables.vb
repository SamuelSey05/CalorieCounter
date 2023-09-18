Module GlobalVariables
    Public Const connection As String = "Server=tcp:caloriecounter.database.windows.net,1433;Initial Catalog=CalorieCounterDB;Persist Security Info=False;User ID=samuelsey05;Password=QkfbUiGTpWy6Qbx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
    'Create a GlobalVariables Module to declare a public constant to store the connection string to my SQL Server
    'Constant allows me to change in only one place and only need to type out the full connection string once
End Module
