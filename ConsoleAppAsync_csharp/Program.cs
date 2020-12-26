using System;
using System.Threading.Tasks;

namespace ConsoleAppAsync_csharp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            await Task.Delay(3000);
            Console.WriteLine($"{args[0]} {args[1]}");

            var results = Task.WhenAll(ExampleOne(), ExampleTwo()).Result;

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            
            Console.ReadKey();
        }

        public static async Task<int> ExampleOne()
        {

            await Task.Delay(2000);

            return 40;

        }

        public static async Task<int> ExampleTwo()
        {
            await Task.Delay(5000);

            return 60;

        }

	}
}
