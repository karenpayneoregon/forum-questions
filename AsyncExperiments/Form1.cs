using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * IAsyncEnumerable<T> Interface
 * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1?view=net-5.0
 * Exposes an enumerator that provides asynchronous iteration over values of a specified type.
 */

namespace YieldIAsyncEnumerable
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationSource = new();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (_cancellationSource.IsCancellationRequested)
            {
                _cancellationSource.Dispose();
                _cancellationSource = new CancellationTokenSource();
            }

            listBox1.Items.Clear();

            try
            {
                await foreach (var item in 10.RangeAsync(GlobalStuff.MaxNumber, _cancellationSource.Token).WithCancellation(_cancellationSource.Token))
                {
                    listBox1.Items.Add(item);
                };
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Operation cancelled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            await foreach (var item in Helper.RangeAsync(3, GlobalStuff.MaxNumber))
            {
                listBox1.Items.Add(item); 
            }

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _cancellationSource.Cancel();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await CountNamesWithN();
        }
        public async Task CountNamesWithN()
        {

            await foreach (var name in DataOperations.GetAllNames(true))
            {
                listBox2.InvokeIfRequired(lb => { listBox2.Items.Add(name);});
            }
        }
    }

    public class GlobalStuff
    {
        public static readonly TimeSpan TimeSpan = new(0, 0, 0, 0, 1);
        public static int MaxNumber = 100;
        public static int TimeOutSeconds = 5;
    }

    public static class Experimenting
    {
        public static async IAsyncEnumerable<int> RangeAsync(this int start, int count, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {

            for (int index = 0; index < count; index++)
            {
                if (cancellationToken.IsCancellationRequested) cancellationToken.ThrowIfCancellationRequested();
                await Task.Delay(GlobalStuff.TimeSpan, cancellationToken);
                yield return start + index;
            }
        }
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
    }

    public class Helper
    {
        public static async IAsyncEnumerable<int> RangeAsync(int divider, int maxNumber)
        {
            for (var index = 0; index < maxNumber; index++)
            {
                if (index % divider == 0)
                {
                    await Task.Delay(GlobalStuff.TimeSpan);
                    yield return index;
                }
            }
        }
    }

    public class DataOperations
    {
        private static readonly string _connectionString = 
            @"Data Source=.\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";

        private static string _selectStatement = 
            "SELECT FirstName + ' ' + LastName As FullName FROM dbo.Contacts ORDER BY LastName;";
        
        public static async IAsyncEnumerable<string> GetAllNames(bool delay)
        {
            
            await using var cn = new SqlConnection(_connectionString);
            await using var cmd = new SqlCommand { Connection = cn, CommandText = _selectStatement };

            await cn.OpenAsync(new CancellationTokenSource(TimeSpan.FromSeconds(GlobalStuff.TimeOutSeconds)).Token);
            await using var reader = await cmd.ExecuteReaderAsync();

            while (reader.Read())
            {
                
                if (delay)
                {
                    await Task.Delay(GlobalStuff.TimeSpan);
                }
                
                yield return reader.GetString(0);
            }

        }
    }
}
