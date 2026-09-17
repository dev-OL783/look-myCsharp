namespace T01Q07___Echo_Trimmed_Name;

class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        // Display prompt
        Console.WriteLine("Hello there, what is your name?");
        // Read name, trim leading and trailing white space
        string name = Console.ReadLine();
        name = name.Trim();
        // Display message including name
        Console.WriteLine("hi " + name + " yep");

        // Keep the following line intact 
        Console.WriteLine("===========================");
    }
} 
