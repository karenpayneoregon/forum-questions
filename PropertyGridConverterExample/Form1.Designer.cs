
namespace PropertyGridConverterExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pgdPeople = new System.Windows.Forms.PropertyGrid();
            this.lstPeople = new System.Windows.Forms.ListBox();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgdPeople
            // 
            this.pgdPeople.Location = new System.Drawing.Point(220, 7);
            this.pgdPeople.Name = "pgdPeople";
            this.pgdPeople.Size = new System.Drawing.Size(381, 417);
            this.pgdPeople.TabIndex = 0;
            // 
            // lstPeople
            // 
            this.lstPeople.FormattingEnabled = true;
            this.lstPeople.ItemHeight = 15;
            this.lstPeople.Location = new System.Drawing.Point(7, 7);
            this.lstPeople.Name = "lstPeople";
            this.lstPeople.Size = new System.Drawing.Size(207, 334);
            this.lstPeople.TabIndex = 1;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(7, 347);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(207, 23);
            this.CurrentButton.TabIndex = 2;
            this.CurrentButton.Text = "button1";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.lstPeople);
            this.Controls.Add(this.pgdPeople);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid pgdPeople;
        private System.Windows.Forms.ListBox lstPeople;
        private System.Windows.Forms.Button CurrentButton;
    }
}

