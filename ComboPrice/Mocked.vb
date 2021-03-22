Public Class Mocked
    ''' <summary>
    ''' Should come from a database or file
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function Colleges() As List(Of College)
        Return New List(Of College) From {
            New College() With {.Id = 1, .Name = "University Of Phoenix", .Credit = 10.5},
            New College() With {.Id = 2, .Name = "Bryn Mawr College", .Credit = 20.5},
            New College() With {.Id = 3, .Name = "Grinnell College", .Credit = 30.5},
            New College() With {.Id = 4, .Name = "Capella University", .Credit = 40.5},
            New College() With {.Id = 5, .Name = "Strayer University", .Credit = 60.5}
            }
    End Function
End Class