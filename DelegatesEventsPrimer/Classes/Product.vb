Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes
    Public Class Product
        Implements INotifyPropertyChanged

        Private _productId As Integer
        Private _productName As String
        Private _unitPrice As Decimal?

        Public Property ProductId As Integer
            Get
                Return _productId
            End Get
            Set
                _productId = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property ProductName As String
            Get
                Return _productName
            End Get
            Set
                _productName = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property UnitPrice As Decimal?
            Get
                Return _unitPrice
            End Get
            Set
                _unitPrice = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return ProductName
        End Function

        Public Property DiscontinuedDate As DateTime?

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
            PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End NameSpace