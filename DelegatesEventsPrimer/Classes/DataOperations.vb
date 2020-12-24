Namespace Classes

    Public Class DataOperations

        Public Delegate Sub OnUpdateProduct(product As ProductItem)
        Public Shared Event OnUpdateProductEvent As OnUpdateProduct

        Public Shared Function GetProducts() As List(Of Product)

            Return New List(Of Product) From {
                New Product() With {
                    .ProductId = 1,
                    .ProductName = "Chai",
                    .UnitPrice = 18.99D,
                    .DiscontinuedDate = New Date(2019, 2, 22)},
                New Product() With {
                    .ProductId = 2,
                    .ProductName = "Chef Anton's Cajun Seasoning",
                    .UnitPrice = 22.99D,
                    .DiscontinuedDate = New Date(2019, 4, 3)}
            }

        End Function

        Public Shared Function UpdateProduct(pProduct As Product) As Boolean

            '
            ' Do database work then if successful raise event below
            '

            Dim st As New StackTrace

            RaiseEvent OnUpdateProductEvent(New ProductItem() With {
                                               .Product = pProduct,
                                               .Sender = st.GetFrame(1).GetMethod.ReflectedType.Name})

            Return True

        End Function

    End Class
End Namespace