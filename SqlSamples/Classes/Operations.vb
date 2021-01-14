Imports System.Data.SqlClient

Namespace Classes
    Public Class Operations

        Private Shared _connectionString As String =
                           "Data Source=.\SQLEXPRESS;" &
                           "Initial Catalog=NorthWindAzureForInserts;" &
                           "Integrated Security=True"

        Public Shared Function InsertItem(companyName As String) As Integer

            Dim newPrimaryKey As Integer = -1

            Dim insertStatement =
                    "INSERT INTO dbo.Customers (CompanyName) VALUES (@CompanyName);" &
                    "SELECT CAST(scope_identity() AS int);"

            Using cn As New SqlConnection With {.ConnectionString = _connectionString}

                Using cmd As New SqlCommand With {.Connection = cn, .CommandText = insertStatement}
                    cmd.Parameters.AddWithValue("@CompanyName", companyName)

                    Try
                        cn.Open()
                        newPrimaryKey = CInt(cmd.ExecuteScalar())
                    Catch ex As Exception
                        HasException = True
                        LastException = ex
                    End Try
                End Using

            End Using

            Return newPrimaryKey

        End Function
        Public Shared LastException As Exception
        Public Shared HasException As Boolean
    End Class
End Namespace