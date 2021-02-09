
namespace TestControls
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
            this.integerTextBox1 = new TeamControls.IntegerTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerCustom1 = new TeamControls.DateTimePickerCustom();
            this.noBeepTextBox1 = new TeamControls.NoBeepTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // integerTextBox1
            // 
            this.integerTextBox1.Id = 12;
            this.integerTextBox1.Location = new System.Drawing.Point(51, 35);
            this.integerTextBox1.Name = "integerTextBox1";
            this.integerTextBox1.Size = new System.Drawing.Size(100, 23);
            this.integerTextBox1.Stash = "My text";
            this.integerTextBox1.TabIndex = 0;
            this.integerTextBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerCustom1
            // 
            this.dateTimePickerCustom1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCustom1.Id = 11;
            this.dateTimePickerCustom1.Location = new System.Drawing.Point(51, 106);
            this.dateTimePickerCustom1.Name = "dateTimePickerCustom1";
            this.dateTimePickerCustom1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerCustom1.Stash = "Date stash";
            this.dateTimePickerCustom1.TabIndex = 2;
            // 
            // noBeepTextBox1
            // 
            this.noBeepTextBox1.Id = 0;
            this.noBeepTextBox1.Location = new System.Drawing.Point(51, 6);
            this.noBeepTextBox1.Name = "noBeepTextBox1";
            this.noBeepTextBox1.Size = new System.Drawing.Size(100, 23);
            this.noBeepTextBox1.Stash = null;
            this.noBeepTextBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Normal";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 250);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.noBeepTextBox1);
            this.Controls.Add(this.dateTimePickerCustom1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.integerTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeamControls.IntegerTextBox integerTextBox1;
        private System.Windows.Forms.Button button1;
        private TeamControls.DateTimePickerCustom dateTimePickerCustom1;
        private TeamControls.NoBeepTextBox noBeepTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

