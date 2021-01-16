Public Module StringExtensions
    <System.Runtime.CompilerServices.Extension>
    Public Function ContainsAny(input As String, containsKeywords As IEnumerable(Of String), comparisonType As StringComparison) As Boolean
        Return containsKeywords.Any(Function(keyword) input.IndexOf(keyword, comparisonType) >= 0)
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function ContainsAny(sender As String, containsKeywords As String, Optional comparisonType As StringComparison = StringComparison.CurrentCultureIgnoreCase) As Boolean
        Return containsKeywords.Any(Function(keyword) sender.IndexOf(keyword, comparisonType) >= 0)
    End Function
End Module
