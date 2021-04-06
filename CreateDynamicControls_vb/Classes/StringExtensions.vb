Imports System.Runtime.CompilerServices

Namespace Classes
    Public Module StringExtensions
        <DebuggerStepThrough>
        <Extension>
        Public Function IsNullOrWhiteSpace(sender As String) As Boolean
            Return String.IsNullOrWhiteSpace(sender)
        End Function
    End Module
End Namespace