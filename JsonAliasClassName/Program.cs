using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JsonAliasClassName
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/standard/data/xml/including-or-importing-xml-schemas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            int lineNumber = 1;
            
            foreach (var items in ChunkLines("TextFile1.txt"))
            {
                if (items.Length == 2 && int.TryParse(items[1], out var value))
                {
                    Console.WriteLine($"{items[0]} - {value}");
                }
                else
                {
                    Console.WriteLine($"Failed on line {lineNumber} or line {lineNumber +1}");

                }

                lineNumber += 2;

            }

            Console.ReadLine();

        }


        public static IEnumerable<string[]> ChunkLines(string fileName, int chunkByLines = 2)
        {
            if (chunkByLines <= 0) throw new ArgumentOutOfRangeException(nameof(chunkByLines));
            
            using var reader = new StreamReader(fileName);
            
            while (!reader.EndOfStream)
            {
                var set = new List<string>();
                
                for (var index = 0; index < chunkByLines && !reader.EndOfStream; index++)
                {
                    set.Add(reader.ReadLine());
                }
                
                yield return set.ToArray();
            }
        }
    }





}

