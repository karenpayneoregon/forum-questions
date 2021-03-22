Public Class Form1
    Private ReadOnly _collegeBindingSource As New BindingSource
    Private ReadOnly _hoursBindingSource As New BindingSource
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        _collegeBindingSource.DataSource = Mocked.Colleges
        SchoolListBox.DataSource = _collegeBindingSource

        AddHandler _collegeBindingSource.PositionChanged, AddressOf _
            BindingSources_PositionChanged

        AddHandler _hoursBindingSource.PositionChanged, AddressOf _
            BindingSources_PositionChanged

        _hoursBindingSource.DataSource = Enumerable.
            Range(100, 10).
            Select(Function(item) (item * 2).ToString()).
            ToList()

        HoursComboBox.DataSource = _hoursBindingSource

    End Sub

    Private Sub BindingSources_PositionChanged(sender As Object, e As EventArgs)
        Dim currentCollege = CType(_collegeBindingSource.Current, College)
        CostLabel.Text =
            $"Cost: {(currentCollege.Credit * CDbl(_hoursBindingSource.Current)).ToString("C")}"
    End Sub
End Class