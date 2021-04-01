Imports System.ComponentModel
Imports System.Runtime.CompilerServices

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

Public Class NumericTextbox
    Inherits TextBox

    Const WM_PASTE As Integer = &H302
    <Browsable(False)>
    Public ReadOnly Property AsDouble As Double
        Get
            If String.IsNullOrWhiteSpace(Text) Then
                Return 0
            Else
                Return CDbl(Text)
            End If
        End Get
    End Property
    Public ReadOnly Property AsDecimal As Decimal
        Get
            If String.IsNullOrWhiteSpace(Text) Then
                Return 0
            Else
                Return CDec(Text)
            End If
        End Get
    End Property
    Public ReadOnly Property AsInteger As Integer
        Get
            If String.IsNullOrWhiteSpace(Text) Then
                Return 0
            Else
                Return CInt(Text)
            End If
        End Get
    End Property
    Public ReadOnly Property IsInteger As Boolean
        Get
            If Integer.TryParse(Text, Nothing) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Public Sub SetDoubleValue(value As Double)
        Text = value.ToString()
    End Sub
    Public Sub SetInteger(value As Integer)
        Text = value.ToString()
    End Sub
    Public Sub SetDecimal(value As Decimal)
        Text = value.ToString()
    End Sub
    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        Dim value As String = Text
        value = value.Remove(SelectionStart, SelectionLength)
        value = value.Insert(SelectionStart, e.KeyChar)

        e.Handled = value.LastIndexOf("-", StringComparison.Ordinal) > 0 Or Not (Char.IsControl(e.KeyChar) OrElse
            Char.IsDigit(e.KeyChar) OrElse (e.KeyChar = "."c And Not Text.Contains(".") Or
            e.KeyChar = "."c And MyBase.SelectedText.Contains(".")) OrElse
            (e.KeyChar = "-"c And SelectionStart = 0))

        MyBase.OnKeyPress(e)

    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg = WM_PASTE Then

            Dim value As String = Text

            value = value.Remove(SelectionStart, SelectionLength)
            value = value.Insert(SelectionStart, Clipboard.GetText)

            Dim result As Decimal = 0
            If Not Decimal.TryParse(value, result) Then
                Return
            End If

        End If

        MyBase.WndProc(m)

    End Sub
End Class
Public Class Example
    Implements INotifyPropertyChanged

    Private _displayBear As Double

    Public Property DisplayBear As Double
        Get
            Return _displayBear
        End Get
        Set

            If ValidAngle(Value) Then
                Console.WriteLine("Valid")
                _displayBear = Value
                OnPropertyChanged()
            Else
                Console.WriteLine("No valid")
            End If

        End Set
    End Property
    Private Function ValidAngle(value As Double) As Boolean
        If value = 10D Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
        PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class

