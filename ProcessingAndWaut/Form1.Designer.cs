
namespace ProcessingAndWait
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
            this.GetIpAddressVersion1Button = new System.Windows.Forms.Button();
            this.GetIpAddressVersion2Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IpAddressTextBox2 = new System.Windows.Forms.TextBox();
            this.IpAddressTextBox1 = new System.Windows.Forms.TextBox();
            this.GetServicesAsJsonButton = new System.Windows.Forms.Button();
            this.ServicesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ServiceCountLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetIpAddressVersion1Button
            // 
            this.GetIpAddressVersion1Button.Location = new System.Drawing.Point(12, 26);
            this.GetIpAddressVersion1Button.Name = "GetIpAddressVersion1Button";
            this.GetIpAddressVersion1Button.Size = new System.Drawing.Size(177, 23);
            this.GetIpAddressVersion1Button.TabIndex = 0;
            this.GetIpAddressVersion1Button.Text = "Version 1";
            this.GetIpAddressVersion1Button.UseVisualStyleBackColor = true;
            this.GetIpAddressVersion1Button.Click += new System.EventHandler(this.GetIpAddressVersion1Button_Click);
            // 
            // GetIpAddressVersion2Button
            // 
            this.GetIpAddressVersion2Button.Location = new System.Drawing.Point(12, 55);
            this.GetIpAddressVersion2Button.Name = "GetIpAddressVersion2Button";
            this.GetIpAddressVersion2Button.Size = new System.Drawing.Size(177, 23);
            this.GetIpAddressVersion2Button.TabIndex = 1;
            this.GetIpAddressVersion2Button.Text = "Version 2";
            this.GetIpAddressVersion2Button.UseVisualStyleBackColor = true;
            this.GetIpAddressVersion2Button.Click += new System.EventHandler(this.GetIpAddressVersion2Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.IpAddressTextBox2);
            this.groupBox1.Controls.Add(this.IpAddressTextBox1);
            this.groupBox1.Controls.Add(this.GetIpAddressVersion2Button);
            this.groupBox1.Controls.Add(this.GetIpAddressVersion1Button);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get IP Address";
            // 
            // IpAddressTextBox2
            // 
            this.IpAddressTextBox2.Location = new System.Drawing.Point(195, 55);
            this.IpAddressTextBox2.Name = "IpAddressTextBox2";
            this.IpAddressTextBox2.Size = new System.Drawing.Size(152, 23);
            this.IpAddressTextBox2.TabIndex = 3;
            // 
            // IpAddressTextBox1
            // 
            this.IpAddressTextBox1.Location = new System.Drawing.Point(195, 26);
            this.IpAddressTextBox1.Name = "IpAddressTextBox1";
            this.IpAddressTextBox1.Size = new System.Drawing.Size(152, 23);
            this.IpAddressTextBox1.TabIndex = 2;
            // 
            // GetServicesAsJsonButton
            // 
            this.GetServicesAsJsonButton.Location = new System.Drawing.Point(35, 135);
            this.GetServicesAsJsonButton.Name = "GetServicesAsJsonButton";
            this.GetServicesAsJsonButton.Size = new System.Drawing.Size(175, 23);
            this.GetServicesAsJsonButton.TabIndex = 3;
            this.GetServicesAsJsonButton.Text = "Get services as json";
            this.GetServicesAsJsonButton.UseVisualStyleBackColor = true;
            this.GetServicesAsJsonButton.Click += new System.EventHandler(this.GetServicesAsJsonButton_Click);
            // 
            // ServicesListView
            // 
            this.ServicesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ServicesListView.FullRowSelect = true;
            this.ServicesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ServicesListView.HideSelection = false;
            this.ServicesListView.Location = new System.Drawing.Point(35, 179);
            this.ServicesListView.MultiSelect = false;
            this.ServicesListView.Name = "ServicesListView";
            this.ServicesListView.Size = new System.Drawing.Size(467, 240);
            this.ServicesListView.TabIndex = 4;
            this.ServicesListView.UseCompatibleStateImageBehavior = false;
            this.ServicesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Display name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Status";
            // 
            // ServiceCountLabel
            // 
            this.ServiceCountLabel.AutoSize = true;
            this.ServiceCountLabel.Location = new System.Drawing.Point(219, 138);
            this.ServiceCountLabel.Name = "ServiceCountLabel";
            this.ServiceCountLabel.Size = new System.Drawing.Size(40, 15);
            this.ServiceCountLabel.TabIndex = 5;
            this.ServiceCountLabel.Text = "Count";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 431);
            this.Controls.Add(this.ServiceCountLabel);
            this.Controls.Add(this.ServicesListView);
            this.Controls.Add(this.GetServicesAsJsonButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process run code samples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetIpAddressVersion1Button;
        private System.Windows.Forms.Button GetIpAddressVersion2Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IpAddressTextBox2;
        private System.Windows.Forms.TextBox IpAddressTextBox1;
        private System.Windows.Forms.Button GetServicesAsJsonButton;
        private System.Windows.Forms.ListView ServicesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label ServiceCountLabel;
        private System.Windows.Forms.Button button1;
    }
}

