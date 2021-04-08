Namespace Classes
    Friend Class ProductComparer
        Implements IComparer(Of Product)

        Public Function Compare(ByVal x As Product, ByVal y As Product) As Integer _
            Implements IComparer(Of Product).Compare

            Dim result As Integer = String.Compare(x.Name, y.Name, StringComparison.Ordinal)
            Return result

        End Function

    End Class
End NameSpace