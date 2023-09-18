Public Class AStudentView

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fAView As New AView
        'Instantiate AView form

        Me.Hide()
        fAView.Show()
        'Open instantiated AView
    End Sub

    'When the text in txtbxUser is changed
    Private Sub txtbxUser_TextChanged(sender As Object, e As EventArgs) Handles txtbxStudent.TextChanged
        dgvStudents.DataSource = TblStudent.searchStudent(txtbxStudent.Text)
        'Refresh the DataGridView with students that have forenames, surnames or usernames that contain the new contents of txtbxUser
    End Sub

    'When a cell is clicked in dgvStudent
    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick
        Dim student As New Student(dgvStudents.CurrentRow.Cells(0).Value.ToString)
        'Instantiate Student with username of selected student
        student.getDetails()
        'Get the details of the selected student 

        Dim fViewHistory As New ViewHistory(student, True)
        'Instantiate ViewHistory form, passing student and True (to show that an admin is using) as parameters to the constructor

        Me.Hide()
        fViewHistory.Show()
        'Open instantiated ViewHistory form
    End Sub
End Class