Public Module StringExtensions
    <Runtime.CompilerServices.Extension>
    Public Function ContainsAny(
        sender As String,
        containsKeywords As String,
        Optional comparisonType As StringComparison = StringComparison.CurrentCultureIgnoreCase) As Boolean
        Return containsKeywords.Any(Function(keyword) sender.IndexOf(keyword, comparisonType) >= 0)
    End Function
End Module
