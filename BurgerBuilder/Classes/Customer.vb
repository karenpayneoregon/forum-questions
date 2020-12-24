Public Class Customer
    Public Property Id() As Integer
    Public Sub New()
        Orders = New List(Of Orders)

        Orders.Add(New Orders() With {
            .OrderId = -1,
            .CustomerIdentifier = -1,
            .OrderDate = Now})

    End Sub
    Public Property CompanyName() As String
    Public Property ContactId() As Integer
    Public Property CountryIdentifier() As Integer
    Public Property Orders() As List(Of Orders)
End Class

Public Class Orders
    Public Property OrderId() As Integer
    Public Property OrderDate() As Date
    Public Property CustomerIdentifier() As Integer
    Public Property ShipAddress() As String
    Public Property ShipCity() As String
    Public Property ShipPostalCode() As String
    Public Property ShipCountryIdentifier() As Integer
End Class
Public Class Country
    Public Property CountryIdentifier() As Integer
    Public Property Name() As String
End Class

