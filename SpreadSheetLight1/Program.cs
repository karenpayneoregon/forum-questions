using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Net;
using SpreadsheetLight;

namespace SpreadSheetLight1
{
    class Program
    {
        static void Main(string[] args)
        {
            string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
            var externalIp = IPAddress.Parse(externalIpString);

            Console.WriteLine(externalIp.ToString());
            
            //try
            //{
            //    using (var doc = new SLDocument())
            //    {
            //        Console.WriteLine($"Create {ExcelFileName}");
            //        doc.SaveAs(ExcelFileName);
            //        Console.WriteLine("Excel file created");

            //    }
            //}
            //catch (UnauthorizedAccessException)
            //{
            //    Console.WriteLine($"Access denied to: {ExcelFileName}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Console.ReadLine();
        }
        
        static string ExcelFileName => 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                "Excel1.xlsx");
    }
}
