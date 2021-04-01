Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CurrencyFormattedLabel1.SetDoubleValue("Total", 123.99, 23, 34.22)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrencyFormattedLabel1.SetDoubleValue(123.99, 23.76, 34.22)

        CalculateOrder.MiscellaneousCharges = 1
        CalculateOrder.Labor = 1
        CalculateOrder.Parts = 1
        TotalLabel.Text = CalculateOrder.PresentTotal
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler CalculateOrder.OnExceptionEvent, AddressOf CalculationError
    End Sub

    Private Sub CalculationError(sender As String)
        Throw New NotImplementedException()
    End Sub

    Private _example As New Example
    Private Sub BearButton_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _example.DisplayBear = BearNumericTextbox.AsDouble
    End Sub
End Class

Public Class CalculateOrder

    Public Delegate Sub OnException(sender As String)
    Public Shared Event OnExceptionEvent As OnException

    Public Shared Property MiscellaneousCharges As Double
    Public Shared Property MiscellaneousSum As Double
    Public Shared Property Labor As Double
    Public Shared Property Parts As Double
    Public Shared Property Tax As Double
    Public Shared ReadOnly Property Total As Double
        Get
            Return PerformCalculation()
        End Get
    End Property
    Public Shared ReadOnly Property PresentTotal As String
        Get
            Return Total.ToString("C")
        End Get
    End Property
    Private Shared Function PerformCalculation() As Double
        Throw New NotImplementedException()
    End Function
    Private Shared Function CalculateTax() As Double
        RaiseEvent OnExceptionEvent("Invalid amount")
        Throw New NotImplementedException()
    End Function
End Class
