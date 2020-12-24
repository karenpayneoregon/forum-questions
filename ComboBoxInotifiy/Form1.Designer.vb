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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IterateItems = New System.Windows.Forms.Button()
        Me.ResultsTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContainsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(21, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'IterateItems
        '
        Me.IterateItems.Location = New System.Drawing.Point(234, 29)
        Me.IterateItems.Name = "IterateItems"
        Me.IterateItems.Size = New System.Drawing.Size(129, 23)
        Me.IterateItems.TabIndex = 1
        Me.IterateItems.Text = "Iterate items"
        Me.IterateItems.UseVisualStyleBackColor = True
        '
        'ResultsTextBox
        '
        Me.ResultsTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultsTextBox.Location = New System.Drawing.Point(21, 94)
        Me.ResultsTextBox.Multiline = True
        Me.ResultsTextBox.Name = "ResultsTextBox"
        Me.ResultsTextBox.Size = New System.Drawing.Size(339, 153)
        Me.ResultsTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Items in basket"
        '
        'ContainsButton
        '
        Me.ContainsButton.Location = New System.Drawing.Point(146, 290)
        Me.ContainsButton.Name = "ContainsButton"
        Me.ContainsButton.Size = New System.Drawing.Size(119, 23)
        Me.ContainsButton.TabIndex = 5
        Me.ContainsButton.Text = "Contains any"
        Me.ContainsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 367)
        Me.Controls.Add(Me.ContainsButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResultsTextBox)
        Me.Controls.Add(Me.IterateItems)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents IterateItems As Button
    Friend WithEvents ResultsTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContainsButton As Button
End Class
