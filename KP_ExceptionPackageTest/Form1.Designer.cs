
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
            this.button1 = new Bootstrap.Control.Button();
            this.button2 = new Bootstrap.Control.Button();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button1.DrawBorder = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.IsOutline = false;
            this.button1.Location = new System.Drawing.Point(17, 64);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(14, 22, 14, 22);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Style = Bootstrap.Control.Button.StyleType.Success;
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.button2.DrawBorder = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button2.IsOutline = false;
            this.button2.Location = new System.Drawing.Point(104, 64);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(14, 22, 14, 22);
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.Style = Bootstrap.Control.Button.StyleType.Primary;
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 110);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReadNonExistingFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unhandle exceptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadNonExistingFileButton;
        private Bootstrap.Control.Button button1;
        private Bootstrap.Control.Button button2;
    }
}

