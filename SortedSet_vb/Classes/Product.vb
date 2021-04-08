Namespace Classes
    Public Class Product

        Public Property Id() As Integer
        Public Property Name() As String
        Public Property CategoryId() As Integer
        Public Property CategoryName() As String
        Public ReadOnly Property Lines() As String
            Get
                Return $"{Id},{Name},{CategoryId}{CategoryName}"
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return $"{CategoryName}, {Name}"
        End Function

    End Class
End NameSpace