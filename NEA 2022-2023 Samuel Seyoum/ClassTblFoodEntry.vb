Imports System.Data.SqlClient
'Uses a SQL NuGet package which allows me to create objects like SqlConnections and SqlDataReaders

Public Class TblFoodEntry
    'This class is never instantiated
    'This class has no attributes
    'This is because this class is only used to allow for the implementation of the methods that carry out operations on tblCustomFood on the CalorieCounterDB database
    'The complexity of the methods of this class is hidden from the non-table classes and therefore the front end (encapsulation)

    'This method adds the user's food entry to the table, either adding a new row or updating an existing one
    Public Shared Sub logFood(ByVal foodEntry As FoodEntry)
        'Takes a FoodEntry as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            addFoodEntry(foodEntry)
        Catch ex As Exception
            'If the program crashes trying to execute the statement above, carry out the following
            'The section above will crash if there is already a food entry for the user at the same time and day with the same food
            foodEntry.Amount += getAmount(foodEntry)
            'Update entry to include original amount as well as amount to be logged

            updateAmount(foodEntry)
        End Try
    End Sub

    'This method searches the food entries of the student specified by user foor any food entries that have a food that contains the string name and occurs on the day iDate and returns the results as a DataTable
    Public Shared Function searchFoodEntry(ByVal name As String, ByVal user As Student, ByVal iDate As Date) As DataTable
        'Takes a string, a student and a date as arguments
        'Returns a DataTable
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("searchFoodEntry", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the strored procedure searchFoodEntry on the database

                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = iDate.Date
                'Add the parameters @Name, @Username and @Date, which are necessary to execute searchFoodEntry

                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                'Execute searchFoodEntry and put results into DataTable dt


                Dim cmd2 As New SqlCommand("searchCustomFoodEntry", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd2 is the stored procedure searchCustomFoodEntry on the database

                cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = name
                cmd2.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                cmd2.Parameters.Add("@Date", SqlDbType.Date).Value = iDate.Date
                'Add the parameters @Name, @Username and @Date, which are necessary to execute searchCustomFoodEntry

                Dim dt2 As New DataTable
                dt2.Load(cmd2.ExecuteReader)
                'Execute searchCustomFoodEntry and put the results into DataTable dt2

                dt.Merge(dt2)
                Return dt
                'Merege dt and dt2 so that all results are returned in a single DataTable
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash

            Return New DataTable
            'Return an empty DataTable
        End Try
    End Function

    'This method stores a new food entry with the specified username, date, time, FoodID, Custom and Amount on the databse
    Public Shared Sub addFoodEntry(ByVal foodEntry As FoodEntry)
        'Takes a FoodEntry as an argument
        Using con As New SqlConnection(connection)
            'Using statement means that connection is closed and then deleted after end of statement

            con.Open()
            'Open the connection to the database

            Dim cmd As New SqlCommand("addFoodEntry", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            'cmd is the stored procedure addFoodEntry on the database

            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = foodEntry.Username
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = foodEntry.tDate.Date
            cmd.Parameters.Add("@Time", SqlDbType.Int).Value = foodEntry.Time
            cmd.Parameters.Add("@FoodID", SqlDbType.Int).Value = foodEntry.FoodID
            cmd.Parameters.Add("@Custom", SqlDbType.Bit).Value = foodEntry.Custom
            cmd.Parameters.Add("@Amount", SqlDbType.Real).Value = foodEntry.Amount
            'Add parameters @Username, @Date, @Time, @FoodID, @Custom and @Amount, which are necessary to execute addFoodEntry

            cmd.ExecuteNonQuery()
            'Execute addFoodEntry

            'This method has no exception handling because, this method is only called once throughout the entire program, in TblFoodEntry.logFood
            'This means that the excption will be handled in logFood, so no exception handling is needed here
        End Using
    End Sub

    'This method gets the amount stored for a certain food logged by a certain user on a certain day at a certain time and returns the amount as a double
    Public Shared Function getAmount(ByVal foodEntry As FoodEntry) As Double
        'Takes a FoodEntry as an argument
        'Returns a double
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("getAmount", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure getAmount on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = foodEntry.Username
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = foodEntry.tDate
                cmd.Parameters.Add("@Time", SqlDbType.Int).Value = foodEntry.Time
                cmd.Parameters.Add("@FoodID", SqlDbType.Int).Value = foodEntry.FoodID
                cmd.Parameters.Add("@Custom", SqlDbType.Bit).Value = foodEntry.Custom
                'Add parameters @Username, @Date, @Time, @FoodID and @Custom, which are necessary to execute getAmount

                Dim amount As Double = cmd.ExecuteScalar()
                Return amount
                'Execute getAmount and return the result in a double
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash

            Return 0
            'If there was an error getting the amount of food logged for a certain user at a certain day amd time, assume there was no food logged, so the amount is 0
        End Try
    End Function

    'This method updates a specified food entry with a new amount
    Public Shared Sub updateAmount(ByVal foodEntry As FoodEntry)
        'Takes a FoodEntry as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("updateAmount", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure updateAmount on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = foodEntry.Username
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = foodEntry.tDate.Date
                cmd.Parameters.Add("@Time", SqlDbType.Int).Value = foodEntry.Time
                cmd.Parameters.Add("@FoodID", SqlDbType.Int).Value = foodEntry.FoodID
                cmd.Parameters.Add("@Custom", SqlDbType.Bit).Value = foodEntry.Custom
                cmd.Parameters.Add("@Amount", SqlDbType.Real).Value = foodEntry.Amount
                'Add parameters @Username, @Date, @Time, @FoodID, @Custom and @Amount, which are necessary to execute updateAmount

                cmd.ExecuteNonQuery()
                'Execute updateAmount
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub

    'This method gets the cals, carbs, fats and proteins eaten by a specified user on a certian day
    Public Shared Sub getStudentDay(ByRef studentDay As StudentDay)
        'Takes StudentDay as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("getStudentDayFood", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure getStudentDayFood on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = studentDay.User.Username
                cmd.Parameters.Add("@sDate", SqlDbType.Date).Value = studentDay.eDate.Date
                cmd.Parameters.Add("@eDate", SqlDbType.Date).Value = studentDay.eDate.Date
                'Add parameters @Username, @sDate and @eDate, which are necessary to execute getStudentDayFood

                Dim cmd2 As New SqlCommand("getStudentDayCustom", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd2 is the stored procedure getStudentDayCustom on the databse

                cmd2.Parameters.Add("@Username", SqlDbType.VarChar).Value = studentDay.User.Username
                cmd2.Parameters.Add("@sDate", SqlDbType.Date).Value = studentDay.eDate.Date
                cmd2.Parameters.Add("@eDate", SqlDbType.Date).Value = studentDay.eDate.Date
                'Add parameters @Username, @sDate and @eDate, which are necessary to execute getStudentDayCustom

                Using StudentDayFood As SqlDataReader = cmd.ExecuteReader
                    'Using statement means that SqlDataReader us closed and then deleted after end of statement
                    'Execute getStudentDayFood and store the results in a SqlDataReader
                    While StudentDayFood.Read()
                        'Only 1 or 0 rows are ever returned to the SqlDataReader, but if 0 are, this segment of code in the while statement is skipped
                        If StudentDayFood.HasRows And Not IsDBNull(StudentDayFood("sumCals")) Then
                            'A second check to make sure that the SqlDataReader has values, to avoid null value errors
                            studentDay.Cals += Math.Round(StudentDayFood("sumCals"), 2)
                            studentDay.Carbs += Math.Round(StudentDayFood("sumCarbs"), 2)
                            studentDay.Fats += Math.Round(StudentDayFood("sumFats"), 2)
                            studentDay.Proteins += Math.Round(StudentDayFood("sumProteins"), 2)
                            'Put the values returned by the SqlDataReader into the corresponding values in the StudentDay that was passed in
                        End If
                    End While
                End Using

                Using StudentDayCustom As SqlDataReader = cmd2.ExecuteReader
                    'Using statement means that SqlDataReader us closed and then deleted after end of statement
                    'Execute getStudentDayCustom and store the results in a SqlDataReader
                    While StudentDayCustom.Read()
                        'Only 1 or 0 rows are ever returned to the SqlDataReader, but if 0 are, this segment of code in the while statement is skipped
                        If StudentDayCustom.HasRows And Not IsDBNull(StudentDayCustom("sumCals")) Then
                            'A second check to make sure that the SqlDataReader has values, to avoid null value errors
                            studentDay.Cals += Math.Round(StudentDayCustom("sumCals"), 2)
                            studentDay.Carbs += Math.Round(StudentDayCustom("sumCarbs"), 2)
                            studentDay.Fats += Math.Round(StudentDayCustom("sumFats"), 2)
                            studentDay.Proteins += Math.Round(StudentDayCustom("sumProteins"), 2)
                            'Put the values returned by the SqlDataReader into the corresponding values in the StudentDay that was passed in
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

    'This method deletes a specified food entry from the table
    Public Shared Sub deleteFoodEntry(ByVal foodEntry As FoodEntry)
        'Takes FoodEntry as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("deleteFoodEntry", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure deleteFoodEntry on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = foodEntry.Username
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = foodEntry.tDate.Date
                cmd.Parameters.Add("@Time", SqlDbType.Int).Value = foodEntry.Time
                cmd.Parameters.Add("@FoodID", SqlDbType.Int).Value = foodEntry.FoodID
                cmd.Parameters.Add("@Custom", SqlDbType.Bit).Value = foodEntry.Custom
                'Add parameters @Username, @Date, @Time, @FoodID and @Custom, which are necessary to execute deleteFoodEntry


                cmd.ExecuteNonQuery()
                'Execute deleteFoodEntry
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub

    'This method gets the cals, carbs, fats, protiens and number of students that have logged meals in a specified yeargroup over a specified time span
    Public Shared Sub getYearSpan(ByRef yearSpan As YearSpan)
        'Takes YearSpan as an argument
        Try
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("getYearAvgFood", con) With {
                        .CommandType = CommandType.StoredProcedure
                    }
                'cmd is the stored procedure getYearAvgFood on the database

                cmd.Parameters.Add("@sDate", SqlDbType.Date).Value = yearSpan.sDate.Date
                cmd.Parameters.Add("@eDate", SqlDbType.Date).Value = yearSpan.eDate.Date
                cmd.Parameters.Add("@Year", SqlDbType.VarChar).Value = yearSpan.Prefix
                'Adds parameters @sDate, @eDate and @Year, which are necessary to execute getYearAvgFood

                Using yearGroupFood As SqlDataReader = cmd.ExecuteReader
                    'Using statement means that SqlDataReader us closed and then deleted after end of statement
                    'Execute getYearAvgFood and store the results in a SqlDataReader
                    While yearGroupFood.Read()
                        'Only 1 or 0 rows are ever returned to the SqlDataReader, but if 0 are, this segment of code in the while statement is skipped
                        If yearGroupFood.HasRows Then
                            'A second check to make sure that the SqlDataReader has values, to avoid null value errors
                            If Not IsDBNull(yearGroupFood("sumCals")) Then
                                'This check makes sure the SqlDataReader is not filled with DBNull values, if sumCals is DBNull, it means that all of the values will be DBNull
                                yearSpan.Cals += Math.Round(yearGroupFood("sumCals"), 2)
                                yearSpan.Carbs += Math.Round(yearGroupFood("sumCarbs"), 2)
                                yearSpan.Fats += Math.Round(yearGroupFood("sumFats"), 2)
                                yearSpan.Proteins += Math.Round(yearGroupFood("sumProteins"), 2)
                                'Put the values returned by the SqlDataReader into the corresponding values in the YearSpan that was passed in
                            End If
                        End If
                    End While
                End Using

                Dim cmd2 As New SqlCommand("getYearAvgCustom", con) With {
                    .CommandType = CommandType.StoredProcedure
                    }
                'cmd2 is the stored procedure getYearAvgCustom on the database

                cmd2.Parameters.Add("@sDate", SqlDbType.Date).Value = yearSpan.sDate.Date
                cmd2.Parameters.Add("@eDate", SqlDbType.Date).Value = yearSpan.eDate.Date
                cmd2.Parameters.Add("@Year", SqlDbType.VarChar).Value = yearSpan.Prefix
                'Adds parameters @sDate, @eDate and @Year, which are necessary to execute getYearAvgCustom

                Using yearGroupCustom As SqlDataReader = cmd2.ExecuteReader
                    'Using statement means that SqlDataReader us closed and then deleted after end of statement
                    'Execute getYearAvgFood and store the results in a SqlDataReader
                    While yearGroupCustom.Read()
                        'Only 1 or 0 rows are ever returned to the SqlDataReader, but if 0 are, this segment of code in the while statement is skipped
                        If yearGroupCustom.HasRows Then
                            'A second check to make sure that the SqlDataReader has values, to avoid null value errors
                            If Not IsDBNull(yearGroupCustom("sumCals")) Then
                                'This check makes sure the SqlDataReader is not filled with DBNull values, if sumCals is DBNull, it means that all of the values will be DBNull
                                yearSpan.Cals += Math.Round(yearGroupCustom("sumCals"), 2)
                                yearSpan.Carbs += Math.Round(yearGroupCustom("sumCarbs"), 2)
                                yearSpan.Fats += Math.Round(yearGroupCustom("sumFats"), 2)
                                yearSpan.Proteins += Math.Round(yearGroupCustom("sumProteins"), 2)
                                'Put the values returned by the SqlDataReader into the corresponding values in the YearSpan that was passed in
                            End If
                        End If
                    End While
                End Using

                Dim cmd3 As New SqlCommand("getYearStudents", con) With {
                   .CommandType = CommandType.StoredProcedure
                   }
                'cmd3 is the storedProcedure getYearStudents on the database

                cmd3.Parameters.Add("@sDate", SqlDbType.Date).Value = yearSpan.sDate.Date
                cmd3.Parameters.Add("@eDate", SqlDbType.Date).Value = yearSpan.eDate.Date
                cmd3.Parameters.Add("@Year", SqlDbType.VarChar).Value = yearSpan.Prefix
                'Adds parameters @sDate, @eDate and @Year, which are necessary to execute getYearStudents

                yearSpan.Count = cmd3.ExecuteScalar
                'Execute getYearStudents and store the results in the Count of the YearSpan that was passed in
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub
End Class