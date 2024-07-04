// See https://aka.ms/new-console-template for more information

using Combinatoric.Enumeration;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int low = 0;
        int high = 5;
        int r = 3;
        int[] items = Enumerable.Range(low, high).ToArray();

        foreach(List<int> combination in items.Combinations(r))
        {
            string combStr = string.Join(",", combination);
            Console.WriteLine(combStr);
        }

        Prompt();
    }

    static void Prompt()
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }
}
