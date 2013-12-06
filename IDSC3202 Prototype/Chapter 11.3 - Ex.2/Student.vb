Public Class Student
    Private m_midterm As Double
    Private m_final As Double

    Public Property Name() As String
    Public Property SocSecNum() As String
    Public Property Datesey() As String


    Public WriteOnly Property Midterm() As Double
        Set(ByVal value As Double)
            m_midterm = value
        End Set
    End Property

    Public WriteOnly Property Final() As Double
        'The student's score on the final exam
        Set(ByVal value As Double)
            m_final = value
        End Set
    End Property
    Overridable Function CalcSemGrade() As String

        Dim grade As Double
        grade = (m_midterm + m_final) / 2
        grade = Math.Round(grade)
        Select Case grade

            Case Is >= 90
                Return "A"
            Case Is >= 80
                Return "B"
            Case Is >= 70
                Return "C"
            Case Is >= 60
                Return "D"
            Case Else
                Return "F"
        End Select
    End Function
End Class

