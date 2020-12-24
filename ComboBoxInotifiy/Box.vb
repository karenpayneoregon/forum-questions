Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Box
    Implements INotifyPropertyChanged

    Private _length As Double
    Private _width As Double
    Private _height As Double

    Public Property Length As Double
        Get
            Return _length
        End Get
        Set
            _length = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Width As Double
        Get
            Return _width
        End Get
        Set
            _width = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Height As Double
        Get
            Return _height
        End Get
        Set
            _height = Value
            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property Volume As Double
    get
        Return Length * Width * Height
    End Get
    End Property
    Public ReadOnly Property Area As Double
    Public ReadOnly Property Other As Double

    Public Overrides Function ToString() As String
        Return $"{Volume}"
    End Function

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
        PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

End Class