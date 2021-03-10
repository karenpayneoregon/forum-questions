using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingWithSqlServer.Classes;

namespace WorkingWithSqlServer
{
    public partial class Form1 : Form
    {
        private const int TimeOutSeconds = 5;
        private CancellationTokenSource _cancellationTokenSource = new(TimeSpan.FromSeconds(TimeOutSeconds));
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
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
                dataGridView1.DataSource = dataResults.DataTable;
            }
        }
    }
}
