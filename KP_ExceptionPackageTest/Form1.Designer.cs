
namespace KP_ExceptionPackageTest
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
            this.ReadNonExistingFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadNonExistingFileButton
            // 
            this.ReadNonExistingFileButton.Location = new System.Drawing.Point(17, 17);
            this.ReadNonExistingFileButton.Name = "ReadNonExistingFileButton";
            this.ReadNonExistingFileButton.Size = new System.Drawing.Size(162, 23);
            this.ReadNonExistingFileButton.TabIndex = 0;
            this.ReadNonExistingFileButton.Text = "Read file not exists";
            this.ReadNonExistingFileButton.UseVisualStyleBackColor = true;
            this.ReadNonExistingFileButton.Click += new System.EventHandler(this.ReadNonExistingFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 110);
            this.Controls.Add(this.ReadNonExistingFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unhandle exceptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadNonExistingFileButton;
    }
}

