Public Class College
    Public Property Id() As Integer
    Public Property Name() As String
    Public Property Credit() As Double

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class