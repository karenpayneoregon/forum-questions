Imports System.Globalization

Namespace Classes
    ''' <summary>
    ''' Creates a list of month names and get current month name
    ''' </summary>
    Public Class Helpers
        ''' <summary>
        ''' Get all month names
        ''' </summary>
        ''' <returns>List of month names</returns>
        Public Shared Function MonthNames() As List(Of String)
            Return Enumerable.Range(1, 12).Select(Function(index) DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList()
        End Function
        ''' <summary>
        ''' Get a partial list of month names starting with month of January
        ''' </summary>
        ''' <param name="months">How many months to return starting with January</param>
        ''' <returns>month names</returns>
        Public Shared Function MonthNames(months As Integer) As List(Of String)
            Return Enumerable.Range(1, months).Select(Function(index) DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList()
        End Function
        Public Shared Function MonthNames(startMonth As Integer, months As Integer) As List(Of String)
            Return Enumerable.Range(startMonth, months).Select(Function(index) DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList()
        End Function
        ''' <summary>
        ''' Get current month name
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property CurrentMonthName() As String
            Get
                Return Now.ToString("MMMM")
            End Get
        End Property
    End Class
End Namespace