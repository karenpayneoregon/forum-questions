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
        Me.CombineFilesButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ExportListButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTotal = New SortedSet_vb.CurrencyLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CombineFilesButton
        '
        Me.CombineFilesButton.Location = New System.Drawing.Point(24, 277)
        Me.CombineFilesButton.Name = "CombineFilesButton"
        Me.CombineFilesButton.Size = New System.Drawing.Size(166, 23)
        Me.CombineFilesButton.TabIndex = 0
        Me.CombineFilesButton.Text = "Combine files"
        Me.CombineFilesButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(688, 258)
        Me.DataGridView1.TabIndex = 1
        '
        'ExportListButton
        '
        Me.ExportListButton.Location = New System.Drawing.Point(217, 277)
        Me.ExportListButton.Name = "ExportListButton"
        Me.ExportListButton.Size = New System.Drawing.Size(166, 23)
        Me.ExportListButton.TabIndex = 2
        Me.ExportListButton.Text = "Export list"
        Me.ExportListButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(528, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(461, 298)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "12.5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 340)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ExportListButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CombineFilesButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Combine text file, sorted and distinct  list"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CombineFilesButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ExportListButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTotal As CurrencyLabel
End Class
