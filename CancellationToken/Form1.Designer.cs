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
            this.RunButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBarSpecial = new ProgressODoom.ProgressBarEx();
            this.metalProgressPainter1 = new ProgressODoom.MetalProgressPainter();
            this.RunButton1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(13, 93);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(130, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(180, 93);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 44);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // ProgressBarSpecial
            // 
            this.ProgressBarSpecial.Location = new System.Drawing.Point(13, 142);
            this.ProgressBarSpecial.MarqueePercentage = 25;
            this.ProgressBarSpecial.MarqueeSpeed = 30;
            this.ProgressBarSpecial.MarqueeStep = 1;
            this.ProgressBarSpecial.Maximum = 100;
            this.ProgressBarSpecial.Minimum = 0;
            this.ProgressBarSpecial.Name = "ProgressBarSpecial";
            this.ProgressBarSpecial.ProgressPadding = 0;
            this.ProgressBarSpecial.ProgressPainter = this.metalProgressPainter1;
            this.ProgressBarSpecial.ProgressType = ProgressODoom.ProgressType.Smooth;
            this.ProgressBarSpecial.ShowPercentage = true;
            this.ProgressBarSpecial.Size = new System.Drawing.Size(297, 23);
            this.ProgressBarSpecial.TabIndex = 4;
            this.ProgressBarSpecial.Value = 0;
            // 
            // metalProgressPainter1
            // 
            this.metalProgressPainter1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.metalProgressPainter1.GlossPainter = null;
            this.metalProgressPainter1.Highlight = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.metalProgressPainter1.ProgressBorderPainter = null;
            // 
            // RunButton1
            // 
            this.RunButton1.Location = new System.Drawing.Point(13, 171);
            this.RunButton1.Name = "RunButton1";
            this.RunButton1.Size = new System.Drawing.Size(130, 23);
            this.RunButton1.TabIndex = 5;
            this.RunButton1.Text = "Run";
            this.RunButton1.UseVisualStyleBackColor = true;
            this.RunButton1.Click += new System.EventHandler(this.RunButton1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RunButton1);
            this.Controls.Add(this.ProgressBarSpecial);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RunButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private ComboBox comboBox1;
        private Button button1;
    }
}

