Public Class AUserManage

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fAMainMenu As New AMainMenu
        'Intsntiate AMainMenu form

        Me.Hide()
        fAMainMenu.Show()
        'Open instantiated AMainMenu form
    End Sub

    'When the text in txtbxStudent is changed
    Private Sub txtbxStudent_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudent.TextChanged
        dgvStudents.DataSource = TblStudent.searchStudent(txtbxStudent.Text)
        'Refresh the DataGridView with students that have forenames, surnames or usernames that contain the new contents of txtbxStudent
    End Sub

    'When a cell is clicked in dgvStudents
    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick
        Dim student As New Student(dgvStudents.CurrentRow.Cells(0).Value.ToString)
        'Instantiate Student with the username of selected student
        student.getDetails()
        'Get the details of instantiated student

        Dim fAUserManage2 As New AUserManage2(student)
        'Instantiate AUserManage2 form, passing student as a parameter to the constructor

        fAUserManage2.ShowDialog()
        'Open instantiated AUserManage2 form in front of current form
    End Sub
End Class