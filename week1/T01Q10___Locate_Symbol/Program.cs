namespace T01Q10___Locate_Symbol;

class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        Console.WriteLine("Please enter a line of text:");
        string lineOfText = Console.ReadLine();
        int firstPos = lineOfText.IndexOf('@');
        int lastPos = lineOfText.LastIndexOf('@');

        Console.WriteLine("The first and last positions of '@' are {0} and {1}, respectively.",
            firstPos, lastPos);

        // Keep the following line intact 
        Console.WriteLine("===========================");   
    }
}