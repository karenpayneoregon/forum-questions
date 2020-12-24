<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCloseForm = New System.Windows.Forms.Button()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.cmdMsgBox = New System.Windows.Forms.Button()
        Me.cmdShowChildForm = New System.Windows.Forms.Button()
        Me.chkTaskbar = New System.Windows.Forms.CheckBox()
        Me.cmdMake = New System.Windows.Forms.Button()
        Me.cmdDetect = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 300)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(292, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCloseForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 261)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 39)
        Me.Panel1.TabIndex = 7
        '
        'cmdCloseForm
        '
        Me.cmdCloseForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmdCloseForm.Location = New System.Drawing.Point(206, 9)
        Me.cmdCloseForm.Name = "cmdCloseForm"
        Me.cmdCloseForm.Size = New System.Drawing.Size(75, 23)
        Me.cmdCloseForm.TabIndex = 0
        Me.cmdCloseForm.Text = "E&xit"
        Me.cmdCloseForm.UseVisualStyleBackColor = true
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(12, 12)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdChange.TabIndex = 0
        Me.cmdChange.Text = "Full"
        Me.cmdChange.UseVisualStyleBackColor = true
        '
        'cmdMsgBox
        '
        Me.cmdMsgBox.Location = New System.Drawing.Point(12, 41)
        Me.cmdMsgBox.Name = "cmdMsgBox"
        Me.cmdMsgBox.Size = New System.Drawing.Size(75, 23)
        Me.cmdMsgBox.TabIndex = 3
        Me.cmdMsgBox.Text = "MsgBox"
        Me.cmdMsgBox.UseVisualStyleBackColor = true
        '
        'cmdShowChildForm
        '
        Me.cmdShowChildForm.Location = New System.Drawing.Point(12, 70)
        Me.cmdShowChildForm.Name = "cmdShowChildForm"
        Me.cmdShowChildForm.Size = New System.Drawing.Size(75, 23)
        Me.cmdShowChildForm.TabIndex = 4
        Me.cmdShowChildForm.Text = "Show form"
        Me.cmdShowChildForm.UseVisualStyleBackColor = true
        '
        'chkTaskbar
        '
        Me.chkTaskbar.AutoSize = true
        Me.chkTaskbar.Checked = true
        Me.chkTaskbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTaskbar.Location = New System.Drawing.Point(93, 16)
        Me.chkTaskbar.Name = "chkTaskbar"
        Me.chkTaskbar.Size = New System.Drawing.Size(65, 17)
        Me.chkTaskbar.TabIndex = 1
        Me.chkTaskbar.Text = "Taskbar"
        Me.chkTaskbar.UseVisualStyleBackColor = true
        '
        'cmdMake
        '
        Me.cmdMake.Location = New System.Drawing.Point(180, 12)
        Me.cmdMake.Name = "cmdMake"
        Me.cmdMake.Size = New System.Drawing.Size(75, 23)
        Me.cmdMake.TabIndex = 2
        Me.cmdMake.Text = "Full"
        Me.cmdMake.UseVisualStyleBackColor = true
        '
        'cmdDetect
        '
        Me.cmdDetect.Location = New System.Drawing.Point(12, 107)
        Me.cmdDetect.Name = "cmdDetect"
        Me.cmdDetect.Size = New System.Drawing.Size(75, 23)
        Me.cmdDetect.TabIndex = 5
        Me.cmdDetect.Text = "Detect"
        Me.cmdDetect.UseVisualStyleBackColor = true
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Location = New System.Drawing.Point(12, 197)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(269, 69)
        Me.ListBox1.TabIndex = 6
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 322)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.cmdDetect)
        Me.Controls.Add(Me.cmdMake)
        Me.Controls.Add(Me.chkTaskbar)
        Me.Controls.Add(Me.cmdShowChildForm)
        Me.Controls.Add(Me.cmdMsgBox)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCloseForm As System.Windows.Forms.Button
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents cmdMsgBox As System.Windows.Forms.Button
    Friend WithEvents cmdShowChildForm As System.Windows.Forms.Button
    Friend WithEvents chkTaskbar As System.Windows.Forms.CheckBox
    Friend WithEvents cmdMake As System.Windows.Forms.Button
    Friend WithEvents cmdDetect As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
