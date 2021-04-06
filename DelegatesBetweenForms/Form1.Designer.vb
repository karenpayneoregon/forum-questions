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
        Me.MonthsListBox = New System.Windows.Forms.ListBox()
        Me.ShowChildForm = New System.Windows.Forms.Button()
        Me.GetCurrentMonthButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MonthsListBox
        '
        Me.MonthsListBox.FormattingEnabled = True
        Me.MonthsListBox.Location = New System.Drawing.Point(12, 8)
        Me.MonthsListBox.Name = "MonthsListBox"
        Me.MonthsListBox.Size = New System.Drawing.Size(211, 121)
        Me.MonthsListBox.TabIndex = 0
        '
        'ShowChildForm
        '
        Me.ShowChildForm.Location = New System.Drawing.Point(12, 135)
        Me.ShowChildForm.Name = "ShowChildForm"
        Me.ShowChildForm.Size = New System.Drawing.Size(211, 23)
        Me.ShowChildForm.TabIndex = 1
        Me.ShowChildForm.Text = "Show child form"
        Me.ShowChildForm.UseVisualStyleBackColor = True
        '
        'GetCurrentMonthButton
        '
        Me.GetCurrentMonthButton.Location = New System.Drawing.Point(12, 164)
        Me.GetCurrentMonthButton.Name = "GetCurrentMonthButton"
        Me.GetCurrentMonthButton.Size = New System.Drawing.Size(211, 23)
        Me.GetCurrentMonthButton.TabIndex = 2
        Me.GetCurrentMonthButton.Text = "Get current"
        Me.GetCurrentMonthButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 216)
        Me.Controls.Add(Me.GetCurrentMonthButton)
        Me.Controls.Add(Me.ShowChildForm)
        Me.Controls.Add(Me.MonthsListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delegates"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthsListBox As ListBox
    Friend WithEvents ShowChildForm As Button
    Friend WithEvents GetCurrentMonthButton As Button
End Class
