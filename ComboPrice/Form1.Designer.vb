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
        Me.HoursComboBox = New System.Windows.Forms.ComboBox()
        Me.SchoolListBox = New System.Windows.Forms.ListBox()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HoursComboBox
        '
        Me.HoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HoursComboBox.FormattingEnabled = True
        Me.HoursComboBox.Location = New System.Drawing.Point(251, 33)
        Me.HoursComboBox.Name = "HoursComboBox"
        Me.HoursComboBox.Size = New System.Drawing.Size(111, 21)
        Me.HoursComboBox.TabIndex = 1
        '
        'SchoolListBox
        '
        Me.SchoolListBox.FormattingEnabled = True
        Me.SchoolListBox.Location = New System.Drawing.Point(12, 33)
        Me.SchoolListBox.Name = "SchoolListBox"
        Me.SchoolListBox.Size = New System.Drawing.Size(233, 147)
        Me.SchoolListBox.TabIndex = 2
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(12, 196)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(28, 13)
        Me.CostLabel.TabIndex = 3
        Me.CostLabel.Text = "Cost"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 233)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.SchoolListBox)
        Me.Controls.Add(Me.HoursComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colleges"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HoursComboBox As ComboBox
    Friend WithEvents SchoolListBox As ListBox
    Friend WithEvents CostLabel As Label
End Class
