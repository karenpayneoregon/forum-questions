﻿using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingWithSqlServer.Classes;

namespace WorkingWithSqlServer
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        /// <summary>
        /// How many seconds to wait for a successful or failed connection to open or not
        /// </summary>
        private const int TimeOutSeconds = 5;
        /// <summary>
        /// Pass the time-out for wait period for the connection. For more on time-out see the following
        /// https://social.technet.microsoft.com/wiki/contents/articles/54260.sql-server-freezes-when-connecting-c.aspx
        /// </summary>
        private CancellationTokenSource _cancellationTokenSource = new(TimeSpan.FromSeconds(TimeOutSeconds));
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;

            DataOperations.ConnectMonitor += DataOperationsOnConnectMonitor;
        }

        private void DataOperationsOnConnectMonitor(string message)
        {
            listBox1.InvokeIfRequired(lb => { lb.Items.Add($"{DateTime.Now:h:mm:ss tt zz}: {message}"); });
        }

        private async void OnShown(object? sender, EventArgs e)
        {
            await LoadData(true);
        }

        private async Task LoadData(bool firstTime = false)
        {
            if (!firstTime)
            {
                if (_cancellationTokenSource.IsCancellationRequested)
                {
                    _cancellationTokenSource.Dispose();
                    _cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(TimeOutSeconds));
                }
            }

            var dataResults = await DataOperations.ReadProductsTask(_cancellationTokenSource.Token);

            if (dataResults.HasException)
            {
                MessageBox.Show(dataResults.ConnectionFailed ? 
                    @"Connection failed" : 
                    dataResults.GeneralException.Message);
            }
            else
            {
                _bindingSource.DataSource = dataResults.DataTable;

                dataGridView1.DataSource = _bindingSource;
                ProductNameTextBox.DataBindings.Add("Text", _bindingSource, "ProductName");

            }
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is null)
            {
                return;
            }
            
            var current = ((DataRowView) _bindingSource.Current).Row;
            var productId = current.Field<int>("ProductID");
            var productName = current.Field<string>("ProductName");

            MessageBox.Show($"{productId}\n{productName}");
        }
    }
}
