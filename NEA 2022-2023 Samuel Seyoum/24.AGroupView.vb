Public Class AGroupView

    'When btnBack is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim fAView As New AView
        'Instantiate AView form

        Me.Hide()
        fAView.Show()
        'Open instantiated AView form
    End Sub

    'Opens GroupView2 form
    Private Sub open(ByVal num As Integer)
        lblEmpty.Visible = False

        If Not (cBox1.Checked Or cBox2.Checked Or cBox3.Checked Or cBox4.Checked Or cBox5.Checked Or cBoxL6.Checked Or cBoxU6.Checked) Then
            lblEmpty.Visible = True
        Else
            Dim fGroupView2 As New AGroupView2(num, cBox1.Checked, cBox2.Checked, cBox3.Checked, cBox4.Checked, cBox5.Checked, cBoxL6.Checked, cBoxU6.Checked)
            'Instantiate GroupView2 form, passing the mode and the year groups selected

            Me.Hide()
            fGroupView2.Show()
            'Open instantiated GroupView2 form
        End If
    End Sub

    'When btnDay is clicked
    Private Sub btnDay_Click(sender As Object, e As EventArgs) Handles btnDay.Click
        open(1)
        'Open GroupView2 in day mode
    End Sub

    'When btnWeek is clicked
    Private Sub btnWeek_Click(sender As Object, e As EventArgs) Handles btnWeek.Click
        open(2)
        'Open GroupView2 in week mode
    End Sub

    'When btnMonth is clicekd
    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        open(3)
        'Open GroupView2 in month mode
    End Sub
End Class