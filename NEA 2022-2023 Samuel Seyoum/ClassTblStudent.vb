Imports System.Data.SqlClient
'Uses a SQL NuGet package which allows me to create objects like SqlConnections and SqlDataReaders

Public Class TblStudent
    'This class is never instantiated
    'This class has no attributes
    'This is because this class is only used to allow for the implementation of the methods that carry out operations on tblCustomFood on the CalorieCounterDB database
    'The complexity of the methods of this class is hidden from the non-table classes and therefore the front end (encapsulation)

    'This method adds a new student to the table
    Public Shared Function addToTable(ByVal user As Student) As Boolean
        'Takes a Student as an argument
        'Returns a boolean
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("addStudent", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure addStudent on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                cmd.Parameters.Add("@Forename", SqlDbType.VarChar).Value = user.Forename
                cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = user.Surname
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = user.DOB
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = user.Gender
                cmd.Parameters.Add("@Weight", SqlDbType.Real).Value = user.Weight
                cmd.Parameters.Add("@Height", SqlDbType.Real).Value = user.Height
                cmd.Parameters.Add("@BFP", SqlDbType.Real).Value = user.BFP
                cmd.Parameters.Add("@PAL", SqlDbType.Real).Value = user.PAL
                cmd.Parameters.Add("@Goal", SqlDbType.Int).Value = user.Goal
                cmd.Parameters.Add("@mCals", SqlDbType.Real).Value = user.mCals
                cmd.Parameters.Add("@Cals", SqlDbType.Real).Value = user.Cals
                cmd.Parameters.Add("@Carbs", SqlDbType.Real).Value = user.Carbs
                cmd.Parameters.Add("@Fats", SqlDbType.Real).Value = user.Fats
                cmd.Parameters.Add("@Proteins", SqlDbType.Real).Value = user.Proteins
                'Adds the parameters @Username, @Forename, @Surname, @Password, @DOB, @Gender, @Weight, @Height, @BFP, @PAL, @Goal, @mCals, @Cals, @Carbs, @Fats and @Protiens, which are necessary to execute addStudent

                cmd.ExecuteNonQuery()
                'Execute addStudent
            End Using

            Return True
            'Return to the main program that adding the new student was a success
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash

            Return False
            'Return to the main program that there was an error in adding the new student
        End Try
    End Function

    'This method updates the values stored for a specified student
    Public Shared Sub updateStudent(ByVal user As Student)
        'Takes a Student as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("editUserDetails", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure editUserDetails on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = user.DOB
                cmd.Parameters.Add("@Weight", SqlDbType.Real).Value = user.Weight
                cmd.Parameters.Add("@Height", SqlDbType.Real).Value = user.Height
                cmd.Parameters.Add("@BFP", SqlDbType.Real).Value = user.BFP
                cmd.Parameters.Add("@PAL", SqlDbType.Real).Value = user.PAL
                cmd.Parameters.Add("@Goal", SqlDbType.Int).Value = user.Goal
                cmd.Parameters.Add("@mCals", SqlDbType.Real).Value = user.mCals
                cmd.Parameters.Add("@Cals", SqlDbType.Real).Value = user.Cals
                cmd.Parameters.Add("@Carbs", SqlDbType.Real).Value = user.Carbs
                cmd.Parameters.Add("@Fats", SqlDbType.Real).Value = user.Fats
                cmd.Parameters.Add("@Proteins", SqlDbType.Real).Value = user.Proteins
                'Adds the parameters @Username, @DOB, @Weight, @Height, @BFP, @PAL, @Goal, @mCals, @Cals, @Carbs, @Fats and @Protiens, which are necessary to execute editUserDetails

                cmd.ExecuteNonQuery()
                'Execute editUserDetails
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub

    'This method loads all of the details of a specified student
    Public Shared Sub getDetails(ByRef user As Student)
        'Takes a Student as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("getUserDetails", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure getUserDetails on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                'Add parameter @Username, which is necessary to execute getUserDetails

                Using DetailReader As SqlDataReader = cmd.ExecuteReader()
                    'Using statement means that SqlDataReader us closed and then deleted after end of statement
                    'Execute getUserDetails and store the results in a SqlDataReader
                    If DetailReader.HasRows Then
                        'Only 1 or 0 rows are ever returned to the SqlDataReader, but if 0 are, this segment of code in the while statement is skipped
                        While DetailReader.Read
                            'A second check to make sure that the SqlDataReader has values, to avoid null value errors
                            user.Forename = DetailReader("Forename")
                            user.Surname = DetailReader("Surname")
                            user.Password = DetailReader("Password")
                            user.DOB = DetailReader("DOB")
                            user.Gender = DetailReader("Gender")
                            user.Weight = DetailReader("Weight")
                            user.Height = DetailReader("Height")
                            user.BFP = Math.Round(DetailReader("BFP"), 2)
                            user.PAL = Math.Round(DetailReader("PAL"), 2)
                            user.Goal = Math.Round(DetailReader("Goal"))
                            user.mCals = Math.Round(DetailReader("mCals"), 2)
                            user.Cals = Math.Round(DetailReader("Cals"), 2)
                            user.Carbs = Math.Round(DetailReader("Carbs"), 2)
                            user.Fats = Math.Round(DetailReader("Fats"), 2)
                            user.Proteins = Math.Round(DetailReader("Proteins"), 2)
                            'Put the values returned by the SqlDataReader into the corresponding values in the Student that was passed in
                            'Round values for BFP, PAL, Goal, mCals, Cals, Carbs, Fats and Proteins as anything after the second decimal place doesnt affect calculations significantly
                        End While
                    End If
                End Using
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub

    'This method searches the student stored for any student whose forename, surname or username contains the string name nad returns the result as a DataTable
    Public Shared Function searchStudent(ByVal name As String) As DataTable
        'Takes a string as a parameter
        'Returns a DataTable
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("searchStudent", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure searchStudent on the databae

                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name
                'Add parameter @Name, which is necessary to execute searchStudent

                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader)
                'Execute searchCustomFood and put the results into DataTable dt

                Return dt
                'Return DataTable dt with results of searchStudent
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash

            Return New DataTable
            'Return an empty DataTable
        End Try
    End Function

    'This method updates the password for a specified student
    Public Shared Sub updatePassword(ByVal user As Student)
        'Takes a Student as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("updatePassword", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure updatePassword on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password
                'Add parameters @Username and @Password, which are necessary to execute updatePassword

                cmd.ExecuteNonQuery()
                'Execute updatePassword
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub

    'This method deletes a specified student from the table
    Public Shared Sub deleteStudent(ByVal user As Student)
        'Takes a Student as an argument
        Try
            'I use a try-catch statement here to reduce the program unnecessarily crashing due to problems with sql commands
            Using con As New SqlConnection(connection)
                'Using statement means that connection is closed and then deleted after end of statement

                con.Open()
                'Open the connection to the database

                Dim cmd As New SqlCommand("deleteStudent", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                'cmd is the stored procedure deleteStudent on the database

                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username
                'Add parameter @Username, which is necessary to execute deleteStuednt

                cmd.ExecuteNonQuery()
                'Execute deleteStudent
            End Using
        Catch ex As SqlException
            'If the program crashes trying to execute the statement above, carry out the following
            MsgBox(ex.ToString)
            'Show an error message with what caused the statement above to crash
        End Try
    End Sub
End Class
