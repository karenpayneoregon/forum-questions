<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExampleForm
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CategoryToCheckTextBox = New System.Windows.Forms.TextBox()
        Me.CheckCategoryButton = New System.Windows.Forms.Button()
        Me.StateCheckBox = New System.Windows.Forms.CheckBox()
        Me.CheckAllButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 21)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(214, 259)
        Me.CheckedListBox1.TabIndex = 0
        '
        'CategoryToCheckTextBox
        '
        Me.CategoryToCheckTextBox.Location = New System.Drawing.Point(12, 311)
        Me.CategoryToCheckTextBox.Name = "CategoryToCheckTextBox"
        Me.CategoryToCheckTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryToCheckTextBox.TabIndex = 1
        '
        'CheckCategoryButton
        '
        Me.CheckCategoryButton.Location = New System.Drawing.Point(118, 309)
        Me.CheckCategoryButton.Name = "CheckCategoryButton"
        Me.CheckCategoryButton.Size = New System.Drawing.Size(122, 23)
        Me.CheckCategoryButton.TabIndex = 2
        Me.CheckCategoryButton.Text = "Set check/uncheck"
        Me.CheckCategoryButton.UseVisualStyleBackColor = True
        '
        'StateCheckBox
        '
        Me.StateCheckBox.AutoSize = True
        Me.StateCheckBox.Location = New System.Drawing.Point(118, 338)
        Me.StateCheckBox.Name = "StateCheckBox"
        Me.StateCheckBox.Size = New System.Drawing.Size(51, 17)
        Me.StateCheckBox.TabIndex = 3
        Me.StateCheckBox.Text = "State"
        Me.StateCheckBox.UseVisualStyleBackColor = True
        '
        'CheckAllButton
        '
        Me.CheckAllButton.Location = New System.Drawing.Point(12, 374)
        Me.CheckAllButton.Name = "CheckAllButton"
        Me.CheckAllButton.Size = New System.Drawing.Size(228, 23)
        Me.CheckAllButton.TabIndex = 4
        Me.CheckAllButton.Text = "Check Add"
        Me.CheckAllButton.UseVisualStyleBackColor = True
        '
        'ExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 418)
        Me.Controls.Add(Me.CheckAllButton)
        Me.Controls.Add(Me.StateCheckBox)
        Me.Controls.Add(Me.CheckCategoryButton)
        Me.Controls.Add(Me.CategoryToCheckTextBox)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CategoryToCheckTextBox As TextBox
    Friend WithEvents CheckCategoryButton As Button
    Friend WithEvents StateCheckBox As CheckBox
    Friend WithEvents CheckAllButton As Button
End Class
