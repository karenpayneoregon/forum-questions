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
        Me.SendButton = New System.Windows.Forms.Button()
        Me.TextBox_SenderEADD = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_sendtoallsubject = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Message = New System.Windows.Forms.TextBox()
        Me.TextBox_Eadd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(12, 33)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(75, 23)
        Me.SendButton.TabIndex = 0
        Me.SendButton.Text = "Button1"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'TextBox_SenderEADD
        '
        Me.TextBox_SenderEADD.Location = New System.Drawing.Point(446, 42)
        Me.TextBox_SenderEADD.Name = "TextBox_SenderEADD"
        Me.TextBox_SenderEADD.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SenderEADD.TabIndex = 1
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(454, 50)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Password.TabIndex = 2
        '
        'TextBox_sendtoallsubject
        '
        Me.TextBox_sendtoallsubject.Location = New System.Drawing.Point(462, 58)
        Me.TextBox_sendtoallsubject.Name = "TextBox_sendtoallsubject"
        Me.TextBox_sendtoallsubject.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_sendtoallsubject.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(470, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'TextBox_Message
        '
        Me.TextBox_Message.Location = New System.Drawing.Point(478, 74)
        Me.TextBox_Message.Name = "TextBox_Message"
        Me.TextBox_Message.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Message.TabIndex = 5
        '
        'TextBox_Eadd
        '
        Me.TextBox_Eadd.Location = New System.Drawing.Point(309, 139)
        Me.TextBox_Eadd.Name = "TextBox_Eadd"
        Me.TextBox_Eadd.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Eadd.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox_Eadd)
        Me.Controls.Add(Me.TextBox_Message)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox_sendtoallsubject)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.TextBox_SenderEADD)
        Me.Controls.Add(Me.SendButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SendButton As Button
    Friend WithEvents TextBox_SenderEADD As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents TextBox_sendtoallsubject As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox_Message As TextBox
    Friend WithEvents TextBox_Eadd As TextBox
End Class
