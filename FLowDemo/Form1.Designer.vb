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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MyPictureBox2 = New FLowDemo.MyPictureBox()
        Me.MyPictureBox1 = New FLowDemo.MyPictureBox()
        Me.MyPictureBox3 = New FLowDemo.MyPictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.MyPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.MyPictureBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.MyPictureBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.MyPictureBox3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(27, 51)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(475, 272)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'MyPictureBox2
        '
        Me.MyPictureBox2.BackgroundImage = Global.FLowDemo.My.Resources.Resources.About
        Me.MyPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MyPictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.MyPictureBox2.Name = "MyPictureBox2"
        Me.MyPictureBox2.PrimaryKey = 2
        Me.MyPictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.MyPictureBox2.TabIndex = 1
        Me.MyPictureBox2.TabStop = False
        '
        'MyPictureBox1
        '
        Me.MyPictureBox1.BackgroundImage = Global.FLowDemo.My.Resources.Resources.bullet
        Me.MyPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MyPictureBox1.Location = New System.Drawing.Point(109, 3)
        Me.MyPictureBox1.Name = "MyPictureBox1"
        Me.MyPictureBox1.PrimaryKey = 1
        Me.MyPictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.MyPictureBox1.TabIndex = 0
        Me.MyPictureBox1.TabStop = False
        '
        'MyPictureBox3
        '
        Me.MyPictureBox3.BackgroundImage = Global.FLowDemo.My.Resources.Resources.Docs
        Me.MyPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MyPictureBox3.Location = New System.Drawing.Point(215, 3)
        Me.MyPictureBox3.Name = "MyPictureBox3"
        Me.MyPictureBox3.PrimaryKey = 3
        Me.MyPictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.MyPictureBox3.TabIndex = 2
        Me.MyPictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.MyPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents MyPictureBox1 As MyPictureBox
    Friend WithEvents MyPictureBox2 As MyPictureBox
    Friend WithEvents MyPictureBox3 As MyPictureBox
    Friend WithEvents Button1 As Button
End Class
