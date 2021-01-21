Imports System.Data.SqlClient

Namespace Classes

    Public Class Operations

        Private Shared ConnectionString As String =
                           "Data Source=.\SQLEXPRESS;" &
                           "Initial Catalog=NorthWind2020;" &
                           "Integrated Security=True"


        Public Shared Async Function LoadCustomersAsync() As Task(Of DataTable)

            Dim dt = New DataTable()

            Dim commandText =
                    <SQL>
                        SELECT C.CustomerIdentifier, 
                               C.CompanyName, 
                               C.ContactId, 
                               CT.FirstName, 
                               CT.LastName
                        FROM Customers AS C
                             INNER JOIN Contacts AS CT ON C.ContactId = CT.ContactId;
                    </SQL>.Value

            Using da = New SqlDataAdapter(commandText, ConnectionString)
                Await Task.Run(Function() da.Fill(dt))
            End Using


            dt.Columns("CustomerIdentifier").ColumnMapping = MappingType.Hidden
            dt.Columns("ContactId").ColumnMapping = MappingType.Hidden

            Return dt

        End Function

    End Class
End Namespace