Imports System.Data.SqlClient
'Uses a SQL NuGet package which allows me to create objects like SqlConnections and SqlDataReaders

Public Class TblCustomFood
    'This class is never instantiated
    'This class has no attributes
    'This is because this class is only used to allow for the implementation of the methods that carry out operations on tblCustomFood on the CalorieCounterDB database
    'The complexity of the methods of this class is hidden from the non-table classes and therefore the front end (encapsulation)

    'This method searches the custom foods of the student specified by user for any foods that contain the string name and returns the results as a DataTable
    Public Shared Function searchCustomFood(ByVal name As String, ByVal user As Student) As DataTable
        'Takes a string and a student as arguments
        'Returns a DataTable
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("searchCustomFood", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure searchCustomFood on the database

                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                'Add parameters @Name and @Username, which are necessary to execute searchCustomFood

                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                'Execute searchCustomFood and put results into DataTable dt

                Return dt
                'Return DataTable dt with results of searchCustomFood
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following 
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash

            Return New DataTable
            'Return an empty DataTable
        End Try
    End Function

    'This method stores a new custom food for the student specified by user with name, cals, carbs, fats, proteins and serve all being stored together on the database, returning the ID given to food, unique for all the foods for that user
    Public Shared Function addCustomFood(ByVal user As Student, ByVal name As String, ByVal cals As Double, ByVal carbs As Double, ByVal fats As Double, ByVal proteins As Double, ByVal serve As Double) As Integer
        'Takes a student, a string and 5 doubles as arguments
        'Returns an integer
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("addCustomFood", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure addCustomFood on the database

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 0
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Cals", SqlDbType.VarChar).Value = cals
                cmd.Parameters.Add("@Carbs", SqlDbType.Real).Value = carbs
                cmd.Parameters.Add("@Fats", SqlDbType.Real).Value = fats
                cmd.Parameters.Add("@Proteins", SqlDbType.Real).Value = proteins
                cmd.Parameters.Add("@Serve", SqlDbType.Real).Value = serve
                'Add parameters @Id, @Username, @Name, @Cals, @Carbs, @Fats, @Proteins and @Serve, which are necessary to execute addCustomFood

                Dim customFoodID As Integer = cmd.ExecuteScalar
                'Execute addCustomFood and store the CFoodID in customFoodID

                Return customFoodID
                'Return the CFoodID of the custom food just added
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash

            Return -1
            'If adding the value to the database fails, this is passed onto the main program by returning -1, which cannot be returned when executing addCustomFood
        End Try
    End Function

    'This method gets the name, cals, carbs, fats, proteins and serve of a custom food stored for a given username and CFoodID
    Public Shared Sub getCustomFood(ByRef customFood As CustomFood)
        'Takes a customFood as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("getCustomFood", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure getCustomFood on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = customFood.Username
                cmd.Parameters.Add("@FoodID", SqlDbType.Int).Value = customFood.FoodID
                'Add parameters @Username and @FoodID, which are necessary to execute getCustomFood

                Using customFoodReader As SqlDataReader = cmd.ExecuteReader()
                    'Using statement means that SqlDataReader us closed and then deleted after end of statement
                    'Execute getCustomFood and store the results in a SqlDataReader
                    While customFoodReader.Read()
                        'Only 1 or 0 rows are ever returned to the SqlDataReader, but if 0 are, this segment of code in the while statement is skipped
                        If customFoodReader.HasRows() Then
                            'A second check to make sure that the SqlDataReader has values, to avoid null value errors
                            customFood.Name = customFoodReader("Name")
                            customFood.Cals = customFoodReader("Cals")
                            customFood.Carbs = customFoodReader("Carbs")
                            customFood.Fats = customFoodReader("Fats")
                            customFood.Proteins = customFoodReader("Proteins")
                            customFood.Serve = customFoodReader("Serve")
                            'Put the values returned by the SqlDataReader into the corresponding values in the CustomFood that was passed in
                        End If
                    End While
                End Using
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub
End Class
