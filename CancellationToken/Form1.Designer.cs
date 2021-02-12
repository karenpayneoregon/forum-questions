using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ProgressODoom;

namespace CancellationToken
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.RunButton = new Button();
            this.CancelButton = new Button();
            this.progressBar1 = new ProgressBar();
            this.ProgressBarSpecial = new ProgressBarEx();
            this.metalProgressPainter1 = new MetalProgressPainter();
            this.RunButton1 = new Button();
            this.button1 = new Button();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new Point(13, 93);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new Size(130, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new EventHandler(this.RunButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new Point(180, 93);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new Size(130, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new EventHandler(this.CancelButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new Point(13, 44);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new Size(297, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // ProgressBarSpecial
            // 
            this.ProgressBarSpecial.Location = new Point(13, 142);
            this.ProgressBarSpecial.MarqueePercentage = 25;
            this.ProgressBarSpecial.MarqueeSpeed = 30;
            this.ProgressBarSpecial.MarqueeStep = 1;
            this.ProgressBarSpecial.Maximum = 100;
            this.ProgressBarSpecial.Minimum = 0;
            this.ProgressBarSpecial.Name = "ProgressBarSpecial";
            this.ProgressBarSpecial.ProgressPadding = 0;
            this.ProgressBarSpecial.ProgressPainter = this.metalProgressPainter1;
            this.ProgressBarSpecial.ProgressType = ProgressType.Smooth;
            this.ProgressBarSpecial.ShowPercentage = true;
            this.ProgressBarSpecial.Size = new Size(297, 23);
            this.ProgressBarSpecial.TabIndex = 4;
            this.ProgressBarSpecial.Value = 0;
            // 
            // metalProgressPainter1
            // 
            this.metalProgressPainter1.Color = Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.metalProgressPainter1.GlossPainter = null;
            this.metalProgressPainter1.Highlight = Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.metalProgressPainter1.ProgressBorderPainter = null;
            // 
            // RunButton1
            // 
            this.RunButton1.Location = new Point(13, 171);
            this.RunButton1.Name = "RunButton1";
            this.RunButton1.Size = new Size(130, 23);
            this.RunButton1.TabIndex = 5;
            this.RunButton1.Text = "Run";
            this.RunButton1.UseVisualStyleBackColor = true;
            this.RunButton1.Click += new EventHandler(this.RunButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new Point(24, 15);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(338, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RunButton1);
            this.Controls.Add(this.ProgressBarSpecial);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RunButton);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RunButton;
        private Button CancelButton;
        private ProgressBar progressBar1;
        private ProgressBarEx ProgressBarSpecial;
        private Button RunButton1;
        private MetalProgressPainter metalProgressPainter1;
        private Button button1;
    }
}

