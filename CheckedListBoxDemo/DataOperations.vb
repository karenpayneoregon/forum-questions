Imports System.Data.OleDb
Public Class DataOperations
    Private Shared _connectionString As String = "TODO"
    Public Delegate Sub OnFinish()
    Public Shared Event Finished As OnFinish


    Public Delegate Sub OnException(sender As Exception)
    Public Shared Event OnExceptionEvent As OnException

    Public Shared Async Function PerformUpdateTask() As Task(Of Boolean)

        Return Await Task.Run(Async Function()
                                  Using cn = New OleDbConnection(_connectionString)

                                      Using cmd = New OleDbCommand() With {.Connection = cn}

                                          cmd.CommandText = "TODO"

                                          Try
                                              Await cn.OpenAsync()
                                              Dim result = Await cmd.ExecuteNonQueryAsync()
                                              RaiseEvent Finished()
                                          Catch ex As Exception
                                              RaiseEvent OnExceptionEvent(ex)
                                              Return False
                                          End Try
                                      End Using
                                  End Using

                                  Return True

                              End Function)

    End Function




End Class
