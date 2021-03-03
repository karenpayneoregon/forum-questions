using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcessingAndWait.Classes;

namespace ProcessingAndWait
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get IP address synchronously
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetIpAddressVersion1Button_Click(object sender, EventArgs e)
        {
            IpAddressTextBox1.Text = "";
            var ipAddress = await PowerShellOperations.GetIpAddress();
            IpAddressTextBox1.Text = ipAddress;
        }
        
        /// <summary>
        /// Get IP address asynchronously
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetIpAddressVersion2Button_Click(object sender, EventArgs e)
        {
            IpAddressTextBox2.Text = "";
            
            string ipAddress = "";
            
            await Task.Run(async () => { ipAddress = await PowerShellOperations.GetIpAddress(); });

            if (!string.IsNullOrWhiteSpace(ipAddress))
            {
                IpAddressTextBox2.Text = ipAddress;
            }
            else
            {
                IpAddressTextBox2.Text = "Failed to obtain IP address";
            }
        }

        /// <summary>
        /// Get all services and their status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetServicesAsJsonButton_Click(object sender, EventArgs e)
        {
            ServicesListView.Items.Clear();

            var serviceItems = await PowerShellOperations.GetServicesAsJson();
            ServiceCountLabel.Text = serviceItems.Count.ToString();
            
            ServicesListView.BeginUpdate();

            try
            {
                foreach (var serviceItem in serviceItems)
                {
                    ServicesListView.Items.Add(new ListViewItem(serviceItem.ItemArray()));
                }

                ServicesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ServicesListView.Items[0].Selected = true;
                ActiveControl = ServicesListView;
                
            }
            finally
            {
                ServicesListView.EndUpdate();
            }
            
            ServicesListView.EnsureVisible(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


    }

    public class IccTrans 
    {
        public decimal ID { get; set; }
        public string SSN { get; set; }
        
    }
}
