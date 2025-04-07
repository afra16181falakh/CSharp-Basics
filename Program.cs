using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to My Basic C# App!");
        Console.WriteLine("---------------------------");
        
        // Get user input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Demonstrate basic operations
        Console.WriteLine($"\nHello, {name}!");
        Console.WriteLine($"Your number plus 10 is: {AddTen(number)}");
        
        // Simple if-else demonstration
        if (number > 50)
        {
            Console.WriteLine("That's a big number!");
        }
        else
        {
            Console.WriteLine("That's a small number!");
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
    
    static int AddTen(int num)
    {
        return num + 10;
    }
}
