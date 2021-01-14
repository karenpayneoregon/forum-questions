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
        Me.CompanyNameComoboBox = New System.Windows.Forms.ComboBox()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CompanyNameComoboBox
        '
        Me.CompanyNameComoboBox.FormattingEnabled = True
        Me.CompanyNameComoboBox.Location = New System.Drawing.Point(18, 19)
        Me.CompanyNameComoboBox.Name = "CompanyNameComoboBox"
        Me.CompanyNameComoboBox.Size = New System.Drawing.Size(156, 23)
        Me.CompanyNameComoboBox.TabIndex = 0
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(180, 19)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertButton.TabIndex = 1
        Me.InsertButton.Text = "Insert"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.CompanyNameComoboBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CompanyNameComoboBox As ComboBox
    Friend WithEvents InsertButton As Button
End Class
