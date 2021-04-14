using System;
using Features_Version9.ClassesAndRecords;

namespace Features_Version9
{
    class Program
    {
        static void Main(string[] args)
        {
            Positionals();
            Console.ReadLine();
        }

        private static void Positionals()
        {
            var (first, last) = new PersonRecord("Karen", "Payne");
            Console.WriteLine($" Person record: {first} {last}");
            
            var personRecord = new PersonRecord(LastName: "Payne", FirstName: "Karen");
            Console.WriteLine($" Person record: {personRecord.FirstName} {personRecord.LastName}");

            Console.WriteLine();

            var person1 = new PersonClass() {FirstName = "Karen", LastName = "Payne"};
            Console.WriteLine($" Person1 class: {person1}");
            
            var person2 = new PersonClass() {LastName = "Payne", FirstName = "Karen"};
            Console.WriteLine($" Person2 class: {person2}");
        }
    }
}
