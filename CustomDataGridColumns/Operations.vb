Public Class Operations
    Private Shared ConnectionString As String =
                       "Data Source=.\SQLEXPRESS;" &
                       "Initial Catalog=NorthWind2020;Integrated Security=True"

    Public Shared Function Read() As DataTable
        Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionString}
            Using cmd As New SqlClient.SqlCommand With {.Connection = cn}


                cmd.CommandText =
                    <SQL>
                        SELECT C.CompanyName, E.FirstName + ' ' + E.LastName AS fullname, O.OrderDate 
                        FROM Orders AS O 
                        INNER JOIN Customers AS C ON O.CustomerIdentifier = C.CustomerIdentifier 
                        INNER JOIN Employees AS E ON O.EmployeeID = E.EmployeeID;
                    </SQL>.Value
                Dim orderTable As New DataTable

                cn.Open()

                orderTable.Load(cmd.ExecuteReader())

                Return orderTable

            End Using
        End Using
    End Function
End Class