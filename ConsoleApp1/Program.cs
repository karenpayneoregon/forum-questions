using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
string dateToConvert = "2021-05-05T21:03:09+00:00";

if (DateTimeOffset.TryParse(dateToConvert, out var result))
{
    Console.WriteLine($"{result}");
    Console.WriteLine($"{result.Date}");
    Console.WriteLine($"{result.LocalDateTime}");
    Console.WriteLine($"{result} {result:O} - {result.ToLocalTime()}");
    Console.WriteLine($"{result.ToLocalTime()}");
}
else
{
    Console.WriteLine("Invalid");
}
            
            
            
            //var fileName = ApplicationSettings.Instance.ProductsFileName;
            //Console.WriteLine($"Reading from: {fileName} ");

            //foreach (var line in ApplicationSettings.Instance.ReadProducts())
            //{
            //    // TODO
            //}

            Console.ReadLine();
        }
    }

    public sealed class ApplicationSettings
    {
        /// <summary>
        /// Creates a thread safe instance of this class
        /// </summary>
        private static readonly Lazy<ApplicationSettings> Lazy = new(() => new ApplicationSettings());
        /// <summary>
        /// Access point to methods and properties
        /// </summary>
        public static ApplicationSettings Instance => Lazy.Value;
        public string ProductsFileName => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFiles", "Products.txt");

        public List<string> ReadProducts()
        {
            
            /*
             * This method is callable only in ReadProducts()
             */
            string MakeUppercase(string sender) => sender.ToUpper();

            var lines = File.ReadAllLines(ProductsFileName).ToList();

            for (int index = 0; index < lines.Count; index++)
            {
                lines[index] = MakeUppercase(lines[index]);
            }
            
            return lines;
        }

       
    }


}
