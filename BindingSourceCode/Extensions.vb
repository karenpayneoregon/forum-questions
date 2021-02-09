Imports System.Windows.Forms

Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Sub RowFilter(pSender As BindingSource, pField As String, pValue As String)
        Dim dt = CType(pSender.DataSource, DataTable)
        dt.DefaultView.RowFilter = $"{pField} = '{pValue.Trim().EscapeApostrophe()}'"
    End Sub
    <Runtime.CompilerServices.Extension>
    Public Sub RowFilter(pSender As BindingSource, pField As String, pValue As Integer)
        Dim dt = CType(pSender.DataSource, DataTable)
        dt.DefaultView.RowFilter = $"{pField} = {pValue}"
    End Sub
    <Runtime.CompilerServices.Extension>
    Public Sub RowFilterClear(pSender As BindingSource)
        CType(pSender.DataSource, DataTable).DefaultView.RowFilter = ""
    End Sub
    <Runtime.CompilerServices.Extension()>
    Public Function DataTable(pSender As BindingSource) As DataTable
        Return DirectCast(pSender.DataSource, DataTable)
    End Function
    <Runtime.CompilerServices.Extension()>
    Public Function CurrentRow(pSender As BindingSource) As DataRow
        Return (CType(pSender.Current, DataRowView)).Row
    End Function
    <Runtime.CompilerServices.Extension()>
    Public Function Locate(pSender As BindingSource, pKey As String, pValue As String) As Integer

        Dim position As Integer = -1

        position = pSender.Find(pKey, pValue)
        If position > -1 Then
            pSender.Position = position
        End If

        Return position

    End Function
    <Runtime.CompilerServices.Extension>
    Public Function EscapeApostrophe(pSender As String) As String
        Return pSender.Replace("'", "''")
    End Function
End Module

Public Class SomeClass
    Public BindingSource As New BindingSource
    Public DataGridView1 As New DataGridView
    Private G_UpdateId As Integer
    Public Sub Load()
        BindingSource.DataSource = GetMockedData()
        DataGridView1.DataSource = BindingSource
    End Sub
    Public Sub FilterData()
        BindingSource.RowFilter("DETAILID", G_UpdateId)
    End Sub
    Public Sub GetCurrentDataRow()
        Dim CurrentRow As DataRow = BindingSource.CurrentRow()
    End Sub
    Public Sub GetTable()
        Dim Table As DataTable = BindingSource.DataTable()


    End Sub

    Public Function GetMockedData() As DataTable
        Return New DataTable()
    End Function

    Public Sub Demo()
        If G_UpdateId > -1 Then
            BindingSource.RowFilter("DETAILID", G_UpdateId)
            G_UpdateId = -1
        End If
    End Sub
End Class
