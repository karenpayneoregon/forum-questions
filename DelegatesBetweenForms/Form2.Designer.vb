<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.SendToParentFormButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MonthsListBox
        '
        Me.MonthsListBox.FormattingEnabled = True
        Me.MonthsListBox.Location = New System.Drawing.Point(17, 14)
        Me.MonthsListBox.Name = "MonthsListBox"
        Me.MonthsListBox.Size = New System.Drawing.Size(208, 160)
        Me.MonthsListBox.TabIndex = 0
        '
        'SendToParentFormButton
        '
        Me.SendToParentFormButton.Location = New System.Drawing.Point(17, 180)
        Me.SendToParentFormButton.Name = "SendToParentFormButton"
        Me.SendToParentFormButton.Size = New System.Drawing.Size(208, 23)
        Me.SendToParentFormButton.TabIndex = 1
        Me.SendToParentFormButton.Text = "Send to parent form"
        Me.SendToParentFormButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 220)
        Me.Controls.Add(Me.SendToParentFormButton)
        Me.Controls.Add(Me.MonthsListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Months window"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthsListBox As ListBox
    Friend WithEvents SendToParentFormButton As Button
End Class
