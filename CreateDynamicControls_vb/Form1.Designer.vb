<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CreateButtonsWhileLoopButton1 = New System.Windows.Forms.Button()
        Me.ButtonTextButton = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListButtonsButton = New System.Windows.Forms.Button()
        Me.CreateOneButtonButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CreateButtonsWhileLoopButton2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StashTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CreateButtonsWhileLoopButton1
        '
        Me.CreateButtonsWhileLoopButton1.Location = New System.Drawing.Point(365, 34)
        Me.CreateButtonsWhileLoopButton1.Name = "CreateButtonsWhileLoopButton1"
        Me.CreateButtonsWhileLoopButton1.Size = New System.Drawing.Size(174, 23)
        Me.CreateButtonsWhileLoopButton1.TabIndex = 0
        Me.CreateButtonsWhileLoopButton1.Text = "Create button with while loop 1"
        Me.CreateButtonsWhileLoopButton1.UseVisualStyleBackColor = True
        '
        'ButtonTextButton
        '
        Me.ButtonTextButton.Location = New System.Drawing.Point(554, 111)
        Me.ButtonTextButton.Name = "ButtonTextButton"
        Me.ButtonTextButton.Size = New System.Drawing.Size(100, 20)
        Me.ButtonTextButton.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(23, 167)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(162, 108)
        Me.ListBox1.TabIndex = 3
        '
        'ListButtonsButton
        '
        Me.ListButtonsButton.Location = New System.Drawing.Point(23, 281)
        Me.ListButtonsButton.Name = "ListButtonsButton"
        Me.ListButtonsButton.Size = New System.Drawing.Size(157, 23)
        Me.ListButtonsButton.TabIndex = 4
        Me.ListButtonsButton.Text = "List buttons"
        Me.ListButtonsButton.UseVisualStyleBackColor = True
        '
        'CreateOneButtonButton
        '
        Me.CreateOneButtonButton.Location = New System.Drawing.Point(365, 109)
        Me.CreateOneButtonButton.Name = "CreateOneButtonButton"
        Me.CreateOneButtonButton.Size = New System.Drawing.Size(174, 23)
        Me.CreateOneButtonButton.TabIndex = 5
        Me.CreateOneButtonButton.Text = "Create buttons one at a time"
        Me.CreateOneButtonButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(23, 34)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(232, 109)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'CreateButtonsWhileLoopButton2
        '
        Me.CreateButtonsWhileLoopButton2.Location = New System.Drawing.Point(365, 63)
        Me.CreateButtonsWhileLoopButton2.Name = "CreateButtonsWhileLoopButton2"
        Me.CreateButtonsWhileLoopButton2.Size = New System.Drawing.Size(174, 23)
        Me.CreateButtonsWhileLoopButton2.TabIndex = 6
        Me.CreateButtonsWhileLoopButton2.Text = "Create button with while loop 2"
        Me.CreateButtonsWhileLoopButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(551, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Button text"
        '
        'StashTextBox
        '
        Me.StashTextBox.Location = New System.Drawing.Point(554, 167)
        Me.StashTextBox.Name = "StashTextBox"
        Me.StashTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StashTextBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Stash"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(23, 342)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(157, 23)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear all buttons"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Button container"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 384)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StashTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CreateButtonsWhileLoopButton2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.CreateOneButtonButton)
        Me.Controls.Add(Me.ListButtonsButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonTextButton)
        Me.Controls.Add(Me.CreateButtonsWhileLoopButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create buttons with events an custom button"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreateButtonsWhileLoopButton1 As Button
    Friend WithEvents ButtonTextButton As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListButtonsButton As Button
    Friend WithEvents CreateOneButtonButton As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents CreateButtonsWhileLoopButton2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents StashTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label3 As Label
End Class
