Imports System.Data.SqlClient
'Uses a SQL NuGet package which allows me to create objects like SqlConnections and SqlDataReaders

Public Class TblFood
    'This class is never instantiated
    'This class has no attributes
    'This is because this class is only used to allow for the implementation of the methods that carry out operations on tblCustomFood on the CalorieCounterDB database
    'The complexity of the methods of this class is hidden from the non-table classes and therefore the front end (encapsulation)

    'This method searches the foods that contain the string name and returns the results as a DataTable
    Public Shared Function searchFood(ByVal name As String) As DataTable
        'Takes a string as an argument
        'Returns a DataTable
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("searchFood", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure searchFood on the database

                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name
                'Add parameter @Name, which is ncessary to execute sarchFood

                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                'Execute seachFood and put results into DataTable dt

                Return dt
                'Return dt with results of executing searchFood
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash

            Return New DataTable
            'Return an empty DataTable
        End Try
    End Function

    'This method gets the name, cals, carbs, fats, proteins and serve of a food for a given FoodID
    Public Shared Sub getFood(ByVal Food As Food)
        'Takes a Food as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("getFood", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the sorred procedure getFood on the database

                cmd.Parameters.Add("@FoodID", SqlDbType.Int).Value = Food.FoodID
                'Add parameter @FoodID which is necessary to execte getFood

                Using foodReader As SqlDataReader = cmd.ExecuteReader
                    'Using statement means that SqlDataReader us closed and then deleted after end of statement
                    'Execute getFood and store the results in a SqlDataReader
                    If foodReader.Read() Then
                        'Only 1 or 0 rows are ever returned to the SqlDataReader, but if 0 are, this segment of code in the while statement is skipped
                        If foodReader.HasRows Then
                            'A second check to make sure that the SqlDataReader has values, to avoid null value errors
                            Food.Name = foodReader("Name")
                            Food.Cals = foodReader("Cals")
                            Food.Carbs = foodReader("Carbs")
                            Food.Fats = foodReader("Fats")
                            Food.Proteins = foodReader("Proteins")
                            Food.Serve = foodReader("Serve")
                        End If
                    End If
                End Using
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub
End Class
