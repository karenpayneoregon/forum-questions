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
        Me.MiataPictureBox = New System.Windows.Forms.PictureBox()
        Me.AllDesktopPictureBox = New System.Windows.Forms.PictureBox()
        Me.GetSelectedButton = New System.Windows.Forms.Button()
        Me.ComputerButton = New CreateDynamicControls_vb.ButtonPictureBox()
        Me.MiataButton = New CreateDynamicControls_vb.ButtonPictureBox()
        CType(Me.MiataPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDesktopPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MiataPictureBox
        '
        Me.MiataPictureBox.Image = Global.CreateDynamicControls_vb.My.Resources.Resources.Miata
        Me.MiataPictureBox.Location = New System.Drawing.Point(39, 23)
        Me.MiataPictureBox.Name = "MiataPictureBox"
        Me.MiataPictureBox.Size = New System.Drawing.Size(520, 346)
        Me.MiataPictureBox.TabIndex = 0
        Me.MiataPictureBox.TabStop = False
        '
        'AllDesktopPictureBox
        '
        Me.AllDesktopPictureBox.Image = Global.CreateDynamicControls_vb.My.Resources.Resources.Anyplatform
        Me.AllDesktopPictureBox.Location = New System.Drawing.Point(565, 23)
        Me.AllDesktopPictureBox.Name = "AllDesktopPictureBox"
        Me.AllDesktopPictureBox.Size = New System.Drawing.Size(445, 346)
        Me.AllDesktopPictureBox.TabIndex = 2
        Me.AllDesktopPictureBox.TabStop = False
        '
        'GetSelectedButton
        '
        Me.GetSelectedButton.Location = New System.Drawing.Point(481, 406)
        Me.GetSelectedButton.Name = "GetSelectedButton"
        Me.GetSelectedButton.Size = New System.Drawing.Size(156, 23)
        Me.GetSelectedButton.TabIndex = 4
        Me.GetSelectedButton.Text = "Get Selected"
        Me.GetSelectedButton.UseVisualStyleBackColor = True
        '
        'ComputerButton
        '
        Me.ComputerButton.Location = New System.Drawing.Point(681, 375)
        Me.ComputerButton.Name = "ComputerButton"
        Me.ComputerButton.PictureBox = Me.AllDesktopPictureBox
        Me.ComputerButton.Size = New System.Drawing.Size(156, 23)
        Me.ComputerButton.TabIndex = 3
        Me.ComputerButton.Text = "Computer"
        Me.ComputerButton.UseVisualStyleBackColor = True
        '
        'MiataButton
        '
        Me.MiataButton.Location = New System.Drawing.Point(164, 375)
        Me.MiataButton.Name = "MiataButton"
        Me.MiataButton.PictureBox = Me.MiataPictureBox
        Me.MiataButton.Size = New System.Drawing.Size(156, 23)
        Me.MiataButton.TabIndex = 1
        Me.MiataButton.Text = "Miata"
        Me.MiataButton.UseVisualStyleBackColor = True
        '
        'ExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 480)
        Me.Controls.Add(Me.GetSelectedButton)
        Me.Controls.Add(Me.ComputerButton)
        Me.Controls.Add(Me.AllDesktopPictureBox)
        Me.Controls.Add(Me.MiataButton)
        Me.Controls.Add(Me.MiataPictureBox)
        Me.Name = "ExampleForm"
        Me.Text = "ExampleForm"
        CType(Me.MiataPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDesktopPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MiataPictureBox As PictureBox
    Friend WithEvents MiataButton As ButtonPictureBox
    Friend WithEvents AllDesktopPictureBox As PictureBox
    Friend WithEvents ComputerButton As ButtonPictureBox
    Friend WithEvents GetSelectedButton As Button
End Class
