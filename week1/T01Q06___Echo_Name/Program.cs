namespace T01Q06___Echo_Name;

class Program
{
    static void Main(string[] args)
    {

        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here:
        //  Display prompt
        Console.WriteLine("Hi there, what is your favorite icecream flavor?");
        //  Read name
        string flavor = Console.ReadLine();
        //  Display message including name
        Console.WriteLine("Nice, your fav flavor is " + flavor + ".");

        // Keep the following line intact 
        Console.WriteLine("===========================");

    }
}