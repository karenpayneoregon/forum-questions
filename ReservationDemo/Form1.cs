using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ControlLibrary;
using ReservationDemo.Classes;

namespace ReservationDemo
{
    public partial class Form1 : Form
    {
        private List<SeatPictureBox> _seatPictureBoxes;
        private List<SeatTable> _seatList;
        public Form1()
        {
            InitializeComponent();

            Prepare();

            UpdateStatus(null,null);
        }

        private void Prepare()
        {
            _seatList = SqlOperations.Read();

            _seatPictureBoxes = Controls.OfType<SeatPictureBox>().ToList();

            foreach (var seatPictureBox in _seatPictureBoxes)
            {
                seatPictureBox.Click += SeatPictureBoxOnClick;
                var currentItem = _seatList.FirstOrDefault(seat => seat.Id == seatPictureBox.Id);
                if (currentItem == null) continue;
                seatPictureBox.Image = currentItem.Available ? imageList1.Images["Available"] : imageList1.Images["Unavailable"];
                seatPictureBox.Available = currentItem.Available;
            }
        }

        private void SeatPictureBoxOnClick(object sender, EventArgs e)
        {
            var pb = (SeatPictureBox) sender;

            //if (pb.Available == false)
            //{
            //    MessageBox.Show($"{pb.Seat} is not available, select another seat");
            //    return;
            //}
            
            if (pb.Available)
            {
                pb.Image = imageList1.Images["Unavailable"];
                pb.Available = false;
            }
            else
            {
                pb.Image = imageList1.Images["Available"];
                pb.Available = true;
            }

            SqlOperations.UpdateSeat(pb.Id, pb.Available);
            UpdateStatus(pb.Id, pb.Available);
        }
        private void UpdateStatus(int? identifier, bool? available)
        {
            listBox1.Items.Clear();
            
            foreach (var box in _seatPictureBoxes.OrderBy(seatPictureBoxx => seatPictureBoxx.Seat))
            {
                listBox1.Items.Add($"{box.Seat} is {box.Available.ToAvailable()}");
            }
        }
    }
    public static class BooleanExtensions
    {
        public static string ToAvailable(this bool value) => value ? "Available" : "Unavailable";
    }
}
