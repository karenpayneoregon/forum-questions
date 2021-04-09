using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CommonExtensions;
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

        private void HasDuplicatesDemo(string identifier)
        {
            var tblData = new DataTable();
            
            tblData.Columns.Add("EMPNO", typeof(string));
            tblData.Columns.Add("NAME", typeof(string));
            tblData.Columns.Add("DEPT", typeof(string));
            tblData.Columns.Add("CATEGORY", typeof(string));
            tblData.Rows.Add("AM-101", "RAFEEK", "CA-12-MM", "BOLD");
            tblData.Rows.Add("AM-101", "RAFEEK", "CA-13-AB", "NEW");
            tblData.Rows.Add("AM-101", "RAFEEK", "CA-13-AB", "NEW");
            tblData.Rows.Add("AM-102", "MANA", "CA-12-MM", "CESS");
            tblData.Rows.Add("AM-102", "MANA", "CA-12-MM", "CESS");
            tblData.Rows.Add("AM-102", "MANA", "CA-13-XL", "REVERSE");
            
            tblData.Columns.Add("ID", typeof(string)).Expression = "EMPNO +NAME";
            tblData.Columns["ID"].SetOrdinal(0);
            
            
            bool hasDuplicates1 = tblData.AsEnumerable().Where(row => row.Field<string>("ID") == identifier)
                .GroupBy(row => row[0]).Any(gr => gr.Count() > 1);

            Console.WriteLine($"From {nameof(HasDuplicatesDemo)}: {hasDuplicates1}"); 

        }
        private void HasNoDuplicatesDemo(string identifier)
        {
            var tblData = new DataTable();

            tblData.Columns.Add("EMPNO", typeof(string));
            tblData.Columns.Add("NAME", typeof(string));
            tblData.Columns.Add("DEPT", typeof(string));
            tblData.Columns.Add("CATEGORY", typeof(string));
            tblData.Rows.Add("AM-101", "RAFEEK", "CA-12-MM", "BOLD");
            tblData.Rows.Add("AM-102", "MANA", "CA-12-MM", "CESS");

            tblData.Columns.Add("ID", typeof(string)).Expression = "EMPNO +NAME";
            tblData.Columns["ID"].SetOrdinal(0);



            Console.WriteLine($"From {nameof(HasNoDuplicatesDemo)}:  {tblData.HasDuplicates("ID", "AM-101RAFEEK")}");

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
        /// <summary>
        /// Update a seat
        /// </summary>
        /// <param name="identifier">Primary key Id for seat</param>
        /// <param name="available">Availability of seat</param>
        private void UpdateStatus(int? identifier, bool? available)
        {
            listBox1.Items.Clear();
            
            foreach (var box in _seatPictureBoxes.OrderBy(seatPictureBox => seatPictureBox.Seat))
            {
                listBox1.Items.Add($"{box.Seat} is {box.Available.ToAvailable()}");
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            //HasDuplicatesDemo("AM-101RAFEEK");
            HasNoDuplicatesDemo("AM-101RAFEEK");
        }
    }
}
