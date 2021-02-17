
namespace UnboundDataGridViewComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddNewRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 20);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(353, 212);
            this.DataGridView1.TabIndex = 0;
            // 
            // AddNewRowButton
            // 
            this.AddNewRowButton.Location = new System.Drawing.Point(12, 248);
            this.AddNewRowButton.Name = "AddNewRowButton";
            this.AddNewRowButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewRowButton.TabIndex = 1;
            this.AddNewRowButton.Text = "New row";
            this.AddNewRowButton.UseVisualStyleBackColor = true;
            this.AddNewRowButton.Click += new System.EventHandler(this.AddNewRowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 293);
            this.Controls.Add(this.AddNewRowButton);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unbound ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button AddNewRowButton;
    }
}

