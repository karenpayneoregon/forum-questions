
namespace ExtenderSample
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
            this.controlExtender1 = new ExtenderSample.ControlExtender();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.controlExtender1.SetCustom1(this.textBox1, "Hello world");
            this.textBox1.Location = new System.Drawing.Point(46, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter some text";
            this.textBox1.Size = new System.Drawing.Size(108, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "";
            // 
            // GetButton
            // 
            this.controlExtender1.SetCustom1(this.GetButton, null);
            this.GetButton.Location = new System.Drawing.Point(176, 25);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 1;
            this.GetButton.Text = "button1";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 114);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.textBox1);
            this.controlExtender1.SetCustom1(this, null);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlExtender controlExtender1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetButton;
    }
}

