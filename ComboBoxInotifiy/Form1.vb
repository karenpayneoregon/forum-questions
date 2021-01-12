Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Text

Public Class Form1
    Private _bindingList As BindingList(Of Product)
    Private ReadOnly _bindingSouce As New BindingSource

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        _bindingList = New BindingList(Of Product)(MockedData.Products())
        _bindingSouce.DataSource = _bindingList

        ComboBox1.DataSource = _bindingSouce

    End Sub

    Private Sub IterateItems_Click(sender As Object, e As EventArgs) Handles IterateItems.Click

        ResultsTextBox.Text = ""
        Dim sb As New StringBuilder

        Dim results = _bindingList.
                GroupBy(Function(product) product.Category).
                Select(Function(item) New CatProduct With {.Category = item.Key, .List = item.ToList()}).
                ToList()

        For Each catProduct As CatProduct In results

            sb.AppendLine(
                $"{catProduct.Category} - " &
                $"{catProduct.List.Sum(Function(item) item.Price * item.Quantity)}")

            For Each product As Product In catProduct.List
                sb.AppendLine($"   {product.Name} - {product.Quantity} - {product.Price.ToString("C2")}")
            Next
        Next

        sb.AppendLine("")

        Dim total = _bindingList.
                GroupBy(Function(product) product.Category).
                Select(Function(item) New With {.Total = item.Sum(Function(x) x.Price * x.Quantity)}).
                Sum(Function(x) x.Total)

        sb.AppendLine($"Total: {total.ToString("C2")}")

        ResultsTextBox.Text = sb.ToString()

    End Sub

    Private Sub ContainsButton_Click(sender As Object, e As EventArgs) Handles ContainsButton.Click

        Dim characters = "QWRTYPSDFGHJKLÑZXCVBNM"
        Dim someText = "1Ñ c"

        If someText.ContainsAny("QWRTYPSDFGHJKLÑZXCVBNM") Then
            Console.WriteLine($"One or more characters were found in {someText}")
        Else
            Console.WriteLine($"Nothing found in {someText} using {characters}")
        End If



    End Sub
End Class

Public Class CatProduct
    Public Property Category As Category
    Public Property List As List(Of Product)
End Class

Public Enum Category
    Toy
    Grocery
    Produce
    Beverages
End Enum
Public Class Base
    Public Property Id() As Integer
    Public Overridable Property Name() As String
End Class
Public Class Product
    Inherits Base
    Implements INotifyPropertyChanged

    Private _name As String
    Private _category As Category
    Private _price As Decimal
    Private _quantity As Integer

    Public Overrides Property Name() As String
        Get
            Return _name
        End Get
        Set
            _name = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Category() As Category
        Get
            Return _category
        End Get
        Set
            _category = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set
            _price = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set
            _quantity = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return $"{Name} {Price}"
    End Function

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

End Class

Public Class SomeOther
    Inherits Product

    Private _cost As Integer

    Public Property Cost() As Integer
        Get
            Return _cost
        End Get
        Set
            _cost = Value
            OnPropertyChanged()
        End Set
    End Property

End Class

Public Class MockedData
    Public Shared Function Products() As List(Of Product)
        Return New List(Of Product) From {
            New Product With {.Id = 100, .Category = Category.Grocery, .Name = "Boysenberry Spread", .Price = 12.88D, .Quantity = 3},
            New Product With {.Id = 342, .Category = Category.Produce, .Name = "Tofu", .Price = 2.99D, .Quantity = 1},
            New Product With {.Id = 4, .Category = Category.Toy, .Name = "MatchBox car", .Price = 5.99D, .Quantity = 5},
            New Product With {.Id = 50, .Category = Category.Produce, .Name = "Rössle Sauerkraut", .Price = 99D, .Quantity = 1}
        }
    End Function
    Public Shared Function OtherProducts() As List(Of SomeOther)
        Return New List(Of SomeOther) From {
            New SomeOther With {.Id = 100, .Category = Category.Grocery, .Name = "Boysenberry Spread", .Price = 12.88D, .Cost = 10.88D, .Quantity = 3},
            New SomeOther With {.Id = 342, .Category = Category.Produce, .Name = "Tofu", .Price = 2.99D, .Cost = 1.88D, .Quantity = 1},
            New SomeOther With {.Id = 4, .Category = Category.Toy, .Name = "MatchBox car", .Price = 5.99D, .Cost = 4.88D, .Quantity = 5},
            New SomeOther With {.Id = 50, .Category = Category.Produce, .Name = "Rössle Sauerkraut", .Cost = 90.88D, .Price = 99D, .Quantity = 1}
            }
    End Function

End Class