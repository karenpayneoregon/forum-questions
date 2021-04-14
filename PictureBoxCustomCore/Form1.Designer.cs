
namespace PictureBoxCustomCore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.proPictureBox1 = new PictureBoxCustomCore.ProPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.proPictureBox2 = new PictureBoxCustomCore.ProPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // proPictureBox1
            // 
            this.proPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("proPictureBox1.Image")));
            this.proPictureBox1.Location = new System.Drawing.Point(49, 34);
            this.proPictureBox1.Name = "proPictureBox1";
            this.proPictureBox1.Size = new System.Drawing.Size(230, 230);
            this.proPictureBox1.TabIndex = 0;
            this.proPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Use mouse and control key to zoom and pan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proPictureBox2
            // 
            this.proPictureBox2.Location = new System.Drawing.Point(314, 84);
            this.proPictureBox2.Name = "proPictureBox2";
            this.proPictureBox2.Size = new System.Drawing.Size(121, 84);
            this.proPictureBox2.TabIndex = 4;
            this.proPictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 384);
            this.Controls.Add(this.proPictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Picturebox";
            ((System.ComponentModel.ISupportInitialize)(this.proPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProPictureBox proPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ProPictureBox proPictureBox2;
    }
}

