Imports System.Data.SqlClient

Public Class SqlOperations
    Private Shared ConnectionString As String =
                "Data Source=.\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True"

    Public Shared Function Categories() As List(Of Category)
        Dim categoriesList = New List(Of Category)
        Dim selectStatement = "SELECT CategoryID, CategoryName FROM Categories;"

        Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
            Using cmd As New SqlCommand With {.Connection = cn}

                cmd.CommandText = selectStatement

                cn.Open()

                Dim reader = cmd.ExecuteReader()
                While reader.Read()
                    categoriesList.Add(New Category() With {.Id = reader.GetInt32(0), .Name = reader.GetString(1)})
                End While


            End Using

        End Using

        Return categoriesList

    End Function

End Class
Public Class Category
    Public Property Id() As Integer
    Public Property Name() As String

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Function SetCategory(sender As CheckedListBox, text As String, Optional checkedValue As Boolean = True) As Boolean

        If String.IsNullOrWhiteSpace(text) Then
            Return False
        End If

        Dim result = CType(sender.DataSource, List(Of Category)).
                Select(Function(item, index) New With
                          {
                            Key .Column = item,
                            Key .Index = index
                          }).FirstOrDefault(Function(this) _
                             String.Equals(this.Column.Name, text, StringComparison.OrdinalIgnoreCase))

        If result IsNot Nothing Then
            sender.SetItemChecked(result.Index, checkedValue)
            Return True
        Else
            Return False
        End If
    End Function

End Module