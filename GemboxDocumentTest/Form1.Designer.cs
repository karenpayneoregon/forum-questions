
namespace GemboxDocumentTest
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
            this.Example1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Example1Button
            // 
            this.Example1Button.Location = new System.Drawing.Point(15, 19);
            this.Example1Button.Name = "Example1Button";
            this.Example1Button.Size = new System.Drawing.Size(159, 23);
            this.Example1Button.TabIndex = 0;
            this.Example1Button.Text = "Example 1";
            this.Example1Button.UseVisualStyleBackColor = true;
            this.Example1Button.Click += new System.EventHandler(this.Example1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 211);
            this.Controls.Add(this.Example1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Example1Button;
    }
}

