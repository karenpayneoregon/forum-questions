using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using SpreadsheetLight;

namespace SpreadSheetLight1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var doc = new SLDocument())
                {
                    Console.WriteLine($"Create {ExcelFileName}");
                    doc.SaveAs(ExcelFileName);
                    Console.WriteLine("Excel file created");

                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Access denied to: {ExcelFileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        
        static string ExcelFileName => 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                "Excel1.xlsx");
    }
}
