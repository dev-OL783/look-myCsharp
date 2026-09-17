namespace T01Q08___Miles_to_Kilometres;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("What the Hell is a kilometerrrr.");
        
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        // Display prompt
        Console.WriteLine("Please supply the distance in miles: ");
        // Read number of miles
        
        // double miles = Console.Readline();
        double miles = double.Parse(Console.ReadLine());

        // Compute equivalent number of kilometres
        double km = miles * 1.609344;
        // Display message involving miles and kilometres
        Console.WriteLine(miles + " miles -> " + km + "kms.");

        // Keep the following line intact 
        Console.WriteLine("===========================");
    }
}
