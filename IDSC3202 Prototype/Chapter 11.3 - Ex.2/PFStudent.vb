Public Class PFStudent
    Inherits Student
    Overrides Function CalcSemGrade() As String
        If MyBase.CalcSemGrade = "F" Then
            Return "Fail"
        Else
            Return "Pass"
        End If
    End Function
End Class
  