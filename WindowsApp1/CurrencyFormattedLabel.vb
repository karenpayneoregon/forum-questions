Imports System.ComponentModel

Public Class CurrencyFormattedLabel
    Inherits Label

    Public Sub New()
        DoubleFormat = "c"
    End Sub

    Public Sub SetDoubleValue(value As Double)
        Text = value.ToString(DoubleFormat)
    End Sub
    Public Sub SetDoubleValue(caption As String, value As Double)
        Text = value.ToString(DoubleFormat)
        Text = $"{caption} {value.ToString(DoubleFormat)}"
    End Sub
    Public Sub SetDoubleValue(value1 As Double, value2 As Double)
        Text = (value1 + value2).ToString(DoubleFormat)
    End Sub
    Public Sub SetDoubleValue(caption As String, value1 As Double, value2 As Double)
        Text = $"{caption} {(value1 + value2).ToString(DoubleFormat)}"
    End Sub
    Public Sub SetDoubleValue(caption As String, ParamArray args() As Double)
        Text = $"{caption} {args.Sum().ToString(DoubleFormat)}"
    End Sub
    Public Sub SetDoubleValue(ParamArray args() As Double)
        Text = args.Sum().ToString(DoubleFormat)
    End Sub

    <Category("Behavior"), Description("Format for SetDoubleValue")>
    Public Property DoubleFormat As String
End Class

