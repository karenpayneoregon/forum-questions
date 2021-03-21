
namespace ReservationDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seatPictureBox4 = new ControlLibrary.SeatPictureBox();
            this.seatPictureBox3 = new ControlLibrary.SeatPictureBox();
            this.seatPictureBox2 = new ControlLibrary.SeatPictureBox();
            this.seatPictureBox1 = new ControlLibrary.SeatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.seatPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Available");
            this.imageList1.Images.SetKeyName(1, "Unavailable");
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(323, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 134);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Row A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Row B";
            // 
            // seatPictureBox4
            // 
            this.seatPictureBox4.Available = true;
            this.seatPictureBox4.Id = 4;
            this.seatPictureBox4.Image = global::ReservationDemo.Properties.Resources.Available;
            this.seatPictureBox4.Location = new System.Drawing.Point(168, 191);
            this.seatPictureBox4.Name = "seatPictureBox4";
            this.seatPictureBox4.Number = 2;
            this.seatPictureBox4.Row = "B";
            this.seatPictureBox4.Size = new System.Drawing.Size(100, 100);
            this.seatPictureBox4.TabIndex = 3;
            this.seatPictureBox4.TabStop = false;
            // 
            // seatPictureBox3
            // 
            this.seatPictureBox3.Available = true;
            this.seatPictureBox3.Id = 3;
            this.seatPictureBox3.Image = global::ReservationDemo.Properties.Resources.Available;
            this.seatPictureBox3.Location = new System.Drawing.Point(35, 191);
            this.seatPictureBox3.Name = "seatPictureBox3";
            this.seatPictureBox3.Number = 1;
            this.seatPictureBox3.Row = "B";
            this.seatPictureBox3.Size = new System.Drawing.Size(100, 100);
            this.seatPictureBox3.TabIndex = 2;
            this.seatPictureBox3.TabStop = false;
            // 
            // seatPictureBox2
            // 
            this.seatPictureBox2.Available = true;
            this.seatPictureBox2.Id = 2;
            this.seatPictureBox2.Image = global::ReservationDemo.Properties.Resources.Available;
            this.seatPictureBox2.Location = new System.Drawing.Point(168, 52);
            this.seatPictureBox2.Name = "seatPictureBox2";
            this.seatPictureBox2.Number = 2;
            this.seatPictureBox2.Row = "A";
            this.seatPictureBox2.Size = new System.Drawing.Size(100, 100);
            this.seatPictureBox2.TabIndex = 1;
            this.seatPictureBox2.TabStop = false;
            // 
            // seatPictureBox1
            // 
            this.seatPictureBox1.Available = true;
            this.seatPictureBox1.Id = 1;
            this.seatPictureBox1.Image = global::ReservationDemo.Properties.Resources.Available;
            this.seatPictureBox1.Location = new System.Drawing.Point(35, 52);
            this.seatPictureBox1.Name = "seatPictureBox1";
            this.seatPictureBox1.Number = 1;
            this.seatPictureBox1.Row = "A";
            this.seatPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.seatPictureBox1.TabIndex = 0;
            this.seatPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.seatPictureBox4);
            this.Controls.Add(this.seatPictureBox3);
            this.Controls.Add(this.seatPictureBox2);
            this.Controls.Add(this.seatPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.seatPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.SeatPictureBox seatPictureBox1;
        private ControlLibrary.SeatPictureBox seatPictureBox2;
        private ControlLibrary.SeatPictureBox seatPictureBox3;
        private ControlLibrary.SeatPictureBox seatPictureBox4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

