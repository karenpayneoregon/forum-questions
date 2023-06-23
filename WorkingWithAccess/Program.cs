using WorkingWithAccess.Classes;

namespace WorkingWithAccess;

internal partial class Program
{
    static void Main(string[] args)
    {
        AnsiConsole.MarkupLine("[yellow]Hello[/]");
        var (success, table) = Operations.CanConnect();
        if (success)
        {
            Console.WriteLine($"read {table.Rows.Count} rows");
        }
        else
        {
            Console.WriteLine("Failed");
        }
        Console.ReadLine();
    }
}