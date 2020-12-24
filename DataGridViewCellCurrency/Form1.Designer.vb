<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Value1Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value2Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value1TextBox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Value1Column, Me.Value2Column})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(251, 207)
        Me.DataGridView1.TabIndex = 0
        '
        'Value1Column
        '
        Me.Value1Column.DataPropertyName = "Value1"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Value1Column.DefaultCellStyle = DataGridViewCellStyle1
        Me.Value1Column.HeaderText = "Value 1"
        Me.Value1Column.Name = "Value1Column"
        '
        'Value2Column
        '
        Me.Value2Column.DataPropertyName = "Value2"
        Me.Value2Column.HeaderText = "Value 2"
        Me.Value2Column.Name = "Value2Column"
        '
        'Value1TextBox
        '
        Me.Value1TextBox.Location = New System.Drawing.Point(282, 8)
        Me.Value1TextBox.Name = "Value1TextBox"
        Me.Value1TextBox.Size = New System.Drawing.Size(100, 23)
        Me.Value1TextBox.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 252)
        Me.Controls.Add(Me.Value1TextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Value1Column As DataGridViewTextBoxColumn
    Friend WithEvents Value2Column As DataGridViewTextBoxColumn
    Friend WithEvents Value1TextBox As TextBox
End Class
