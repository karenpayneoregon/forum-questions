﻿
namespace PictureBoxCustom
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
            this.proPictureBox1 = new ProPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // proPictureBox1
            // 
            this.proPictureBox1.Image = global::PictureBoxCustom.Properties.Resources.Miata;
            this.proPictureBox1.Location = new System.Drawing.Point(55, 69);
            this.proPictureBox1.Name = "proPictureBox1";
            this.proPictureBox1.Size = new System.Drawing.Size(233, 183);
            this.proPictureBox1.TabIndex = 0;
            this.proPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Use mouse and control key to zoom and pan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.proPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProPictureBox proPictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
