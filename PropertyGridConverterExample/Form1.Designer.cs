
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
            PeopleGrid = new PropertyGrid();
            PeopleListBox = new ListBox();
            CurrentButton = new Button();
            SuspendLayout();
            // 
            // PeopleGrid
            // 
            PeopleGrid.Location = new Point(251, 9);
            PeopleGrid.Margin = new Padding(3, 4, 3, 4);
            PeopleGrid.Name = "PeopleGrid";
            PeopleGrid.Size = new Size(483, 556);
            PeopleGrid.TabIndex = 0;
            // 
            // PeopleListBox
            // 
            PeopleListBox.FormattingEnabled = true;
            PeopleListBox.Location = new Point(8, 9);
            PeopleListBox.Margin = new Padding(3, 4, 3, 4);
            PeopleListBox.Name = "PeopleListBox";
            PeopleListBox.Size = new Size(236, 444);
            PeopleListBox.TabIndex = 1;
            // 
            // CurrentButton
            // 
            CurrentButton.Location = new Point(8, 463);
            CurrentButton.Margin = new Padding(3, 4, 3, 4);
            CurrentButton.Name = "CurrentButton";
            CurrentButton.Size = new Size(237, 31);
            CurrentButton.TabIndex = 2;
            CurrentButton.Text = "Current";
            CurrentButton.UseVisualStyleBackColor = true;
            CurrentButton.Click += CurrentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 600);
            Controls.Add(CurrentButton);
            Controls.Add(PeopleListBox);
            Controls.Add(PeopleGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PropertyGrid code sample";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PropertyGrid PeopleGrid;
        private System.Windows.Forms.ListBox PeopleListBox;
        private System.Windows.Forms.Button CurrentButton;
    }
}

