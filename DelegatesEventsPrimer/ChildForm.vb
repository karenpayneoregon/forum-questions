Imports System.ComponentModel
Imports DelegatesEventsPrimer.Classes

Public Class ChildForm
    Private _productBindingList As New BindingList(Of Product)
    Private _productBindingSource As New BindingSource
    Public Sub New(product As Product)

        InitializeComponent()

        Dim pl As New List(Of Product)
        pl.Add(product)
        _productBindingList = New BindingList(Of Product)(pl)

    End Sub
    Private Sub ChildForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        AddHandler DataOperations.OnUpdateProductEvent, AddressOf OnProductUpdate
        AddHandler _productBindingList.ListChanged, AddressOf ProductListChanged

        _productBindingSource.DataSource = _productBindingList

        ProductNameTextBox.DataBindings.Add("Text", _productBindingList, "ProductName")
        UnitPriceTextBox.DataBindings.Add("Text", _productBindingList, "UnitPrice")

    End Sub

    Private Sub ProductListChanged(sender As Object, e As ListChangedEventArgs)
        If e.ListChangedType = ListChangedType.ItemChanged Then
            DataOperations.UpdateProduct(_productBindingList(_productBindingSource.Position))
        End If
    End Sub

    Private Sub OnProductUpdate(pProductItem As ProductItem)
        If Not pProductItem.Sender = Name Then
            ProductNameTextBox.Text = pProductItem.Product.ProductName
        End If
    End Sub
End Class