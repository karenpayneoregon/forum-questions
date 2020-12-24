Imports System.ComponentModel
Imports DelegatesEventsPrimer.Classes

Public Class Form1
    Private _productBindingList As New BindingList(Of Product)
    Private _productBindingSource As New BindingSource
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        AddHandler DataOperations.OnUpdateProductEvent, AddressOf OnProductUpdate

        _productBindingList = New BindingList(Of Product)(DataOperations.GetProducts())
        _productBindingSource.DataSource = _productBindingList

        ProductNameTextBox.DataBindings.Add("Text", _productBindingList, "ProductName")
        UnitPriceTextBox.DataBindings.Add("Text", _productBindingList, "UnitPrice")

    End Sub

    Private Sub OnProductUpdate(pProductItem As ProductItem)
        If Not pProductItem.Sender = Name Then
            ProductNameTextBox.Text = pProductItem.Product.ProductName
        End If
    End Sub

    Private Sub OpenChildFormButton_Click(sender As Object, e As EventArgs) Handles OpenChildFormButton.Click

        Dim childForm As New ChildForm(_productBindingList(_productBindingSource.Position))

        childForm.Show()

    End Sub
End Class
