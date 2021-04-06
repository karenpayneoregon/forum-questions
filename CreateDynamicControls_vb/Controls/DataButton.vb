Namespace Controls
    Public Class DataButton
        Inherits Button
        ''' <summary>
        ''' Useful for assigning a key from a database table primary key etc
        ''' </summary>
        ''' <returns></returns>
        Public Property Identifier() As Integer
        ''' <summary>
        ''' Useful for storing whatever such as a comment
        ''' </summary>
        ''' <returns></returns>
        Public Property Stash() As String
    End Class
End Namespace