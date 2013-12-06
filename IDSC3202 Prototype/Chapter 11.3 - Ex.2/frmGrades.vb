Public Class frmGrades
    Dim students(50) As Student
    Dim lastStudentAdded As Integer = -1
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim pupil As Student
        If rad1099.Checked Then
            pupil = New PFStudent()
        Else
            pupil = New Student()
        End If
        pupil.Name = txtName.Text
        pupil.SocSecNum = mtbSSN.Text
        pupil.Midterm = CDbl(txtMidterm.Text)
        pupil.Final = CDbl(txtFinal.Text)
        lastStudentAdded += 1
        students(lastStudentAdded) = pupil
        txtName.Clear()
        mtbSSN.Clear()
        txtMidterm.Clear()
        txtFinal.Clear()
        MessageBox.Show("Thank you for registering")
        txtName.Focus()
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        ReDim Preserve students(lastStudentAdded)
        Dim query = From pupil In students
                    Select pupil.Name, pupil.SocSecNum, pupil.CalcSemGrade
        dgvGrades.DataSource = query.ToList
        dgvGrades.CurrentCell = Nothing
        dgvGrades.Columns("Name").HeaderText = "Name"
        dgvGrades.Columns("SocSecNum").HeaderText = "SSN"
        'dgvGrades.Columns("Date").HeaderText = "Date"
        'dgvGrades.Columns("Form").HeaderText = "Form"
        ReDim Preserve students(50)
        txtName.Focus()
    End Sub

    Private Sub Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quit.Click
        Me.Close()
    End Sub
End Class
