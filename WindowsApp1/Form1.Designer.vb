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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BearNumericTextbox = New CustomCurrencyLabelDemo.NumericTextbox()
        Me.CurrencyFormattedLabel1 = New CustomCurrencyLabelDemo.CurrencyFormattedLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(109, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(36, 89)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(39, 13)
        Me.TotalLabel.TabIndex = 5
        Me.TotalLabel.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(35, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "BearButton"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BearNumericTextbox
        '
        Me.BearNumericTextbox.Location = New System.Drawing.Point(28, 159)
        Me.BearNumericTextbox.Name = "BearNumericTextbox"
        Me.BearNumericTextbox.Size = New System.Drawing.Size(100, 20)
        Me.BearNumericTextbox.TabIndex = 6
        '
        'CurrencyFormattedLabel1
        '
        Me.CurrencyFormattedLabel1.AutoSize = True
        Me.CurrencyFormattedLabel1.DoubleFormat = "C"
        Me.CurrencyFormattedLabel1.Location = New System.Drawing.Point(12, 23)
        Me.CurrencyFormattedLabel1.Name = "CurrencyFormattedLabel1"
        Me.CurrencyFormattedLabel1.Size = New System.Drawing.Size(128, 13)
        Me.CurrencyFormattedLabel1.TabIndex = 1
        Me.CurrencyFormattedLabel1.Text = "CurrencyFormattedLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 243)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BearNumericTextbox)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CurrencyFormattedLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom label"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CurrencyFormattedLabel1 As CurrencyFormattedLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents BearNumericTextbox As NumericTextbox
    Friend WithEvents Button3 As Button
End Class
