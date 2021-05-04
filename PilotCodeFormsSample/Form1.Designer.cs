
namespace PilotCodeFormsSample
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
            this.textBoxDeparture = new System.Windows.Forms.TextBox();
            this.textBoxArrival = new System.Windows.Forms.TextBox();
            this.textBoxAlternate = new System.Windows.Forms.TextBox();
            this.textBoxAltitude = new System.Windows.Forms.TextBox();
            this.textBoxFlightPlan = new System.Windows.Forms.TextBox();
            this.PilotComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxDeparture
            // 
            this.textBoxDeparture.Location = new System.Drawing.Point(13, 48);
            this.textBoxDeparture.Name = "textBoxDeparture";
            this.textBoxDeparture.Size = new System.Drawing.Size(462, 23);
            this.textBoxDeparture.TabIndex = 1;
            // 
            // textBoxArrival
            // 
            this.textBoxArrival.Location = new System.Drawing.Point(13, 78);
            this.textBoxArrival.Name = "textBoxArrival";
            this.textBoxArrival.Size = new System.Drawing.Size(462, 23);
            this.textBoxArrival.TabIndex = 2;
            // 
            // textBoxAlternate
            // 
            this.textBoxAlternate.Location = new System.Drawing.Point(13, 108);
            this.textBoxAlternate.Name = "textBoxAlternate";
            this.textBoxAlternate.Size = new System.Drawing.Size(462, 23);
            this.textBoxAlternate.TabIndex = 3;
            // 
            // textBoxAltitude
            // 
            this.textBoxAltitude.Location = new System.Drawing.Point(12, 138);
            this.textBoxAltitude.Name = "textBoxAltitude";
            this.textBoxAltitude.Size = new System.Drawing.Size(463, 23);
            this.textBoxAltitude.TabIndex = 4;
            // 
            // textBoxFlightPlan
            // 
            this.textBoxFlightPlan.Location = new System.Drawing.Point(12, 168);
            this.textBoxFlightPlan.Multiline = true;
            this.textBoxFlightPlan.Name = "textBoxFlightPlan";
            this.textBoxFlightPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFlightPlan.Size = new System.Drawing.Size(463, 76);
            this.textBoxFlightPlan.TabIndex = 5;
            // 
            // PilotComboBox
            // 
            this.PilotComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PilotComboBox.FormattingEnabled = true;
            this.PilotComboBox.Location = new System.Drawing.Point(12, 6);
            this.PilotComboBox.Name = "PilotComboBox";
            this.PilotComboBox.Size = new System.Drawing.Size(121, 23);
            this.PilotComboBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 277);
            this.Controls.Add(this.PilotComboBox);
            this.Controls.Add(this.textBoxFlightPlan);
            this.Controls.Add(this.textBoxAltitude);
            this.Controls.Add(this.textBoxAlternate);
            this.Controls.Add(this.textBoxArrival);
            this.Controls.Add(this.textBoxDeparture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read specific json";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDeparture;
        private System.Windows.Forms.TextBox textBoxArrival;
        private System.Windows.Forms.TextBox textBoxAlternate;
        private System.Windows.Forms.TextBox textBoxAltitude;
        private System.Windows.Forms.TextBox textBoxFlightPlan;
        private System.Windows.Forms.ComboBox PilotComboBox;
    }
}

