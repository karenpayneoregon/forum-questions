using System;
using UtilityLibrary;

namespace UtilityLibraryConsole
{
class Program
{
    static void Main(string[] args)
    {
        var currentEventIdentifier = "000000000";

        for (int index = 0; index < 5; index++)
        {
            currentEventIdentifier = EventIncrementer.Instance.EventSequence(currentEventIdentifier);
            Console.WriteLine(currentEventIdentifier);
        }

        Console.WriteLine();
        currentEventIdentifier = "AS0000000";
        for (int index = 0; index < 5; index++)
        {
            currentEventIdentifier = EventIncrementer.Instance.EventSequence(currentEventIdentifier);
            Console.WriteLine(currentEventIdentifier);
        }


        Console.ReadLine();
    }
}
}
