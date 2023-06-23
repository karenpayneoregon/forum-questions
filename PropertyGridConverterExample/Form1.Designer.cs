
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
            this.PeopleGrid = new System.Windows.Forms.PropertyGrid();
            this.lstPeople = new System.Windows.Forms.ListBox();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleGrid
            // 
            this.PeopleGrid.Location = new System.Drawing.Point(251, 9);
            this.PeopleGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PeopleGrid.Name = "PeopleGrid";
            this.PeopleGrid.Size = new System.Drawing.Size(435, 556);
            this.PeopleGrid.TabIndex = 0;
            // 
            // lstPeople
            // 
            this.lstPeople.FormattingEnabled = true;
            this.lstPeople.ItemHeight = 20;
            this.lstPeople.Location = new System.Drawing.Point(8, 9);
            this.lstPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPeople.Name = "lstPeople";
            this.lstPeople.Size = new System.Drawing.Size(236, 444);
            this.lstPeople.TabIndex = 1;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(8, 463);
            this.CurrentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(237, 31);
            this.CurrentButton.TabIndex = 2;
            this.CurrentButton.Text = "button1";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 600);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.lstPeople);
            this.Controls.Add(this.PeopleGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid PeopleGrid;
        private System.Windows.Forms.ListBox lstPeople;
        private System.Windows.Forms.Button CurrentButton;
    }
}

