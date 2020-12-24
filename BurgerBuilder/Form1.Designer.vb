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
        Me.BuildBurgerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'BuildBurgerButton
        '
        Me.BuildBurgerButton.Location = New System.Drawing.Point(10, 24)
        Me.BuildBurgerButton.Name = "BuildBurgerButton"
        Me.BuildBurgerButton.Size = New System.Drawing.Size(150, 23)
        Me.BuildBurgerButton.TabIndex = 0
        Me.BuildBurgerButton.Text = "Build a burger"
        Me.BuildBurgerButton.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 159)
        Me.Controls.Add(Me.BuildBurgerButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Builder pattern"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents BuildBurgerButton As Button
End Class
