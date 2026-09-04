namespace T04Q01___Who_Lives_There;

/// <summary>
/// The main class that executes the entire program. It will accept information 
/// from the user to produce a representation of a person.  
/// </summary>
class Program
{
    /// <summary>
    /// The main method.
    /// </summary>
    /// <param name="args">Command line arguments. These are not used in the program.</param>
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Declare input constants
        const string PREFIX = "Please enter the person's ";

        // Prompt and receive information from input
        Console.WriteLine(PREFIX + "name:");
        string name = Console.ReadLine();
        Console.WriteLine(PREFIX + "age:");
        int age = Int32.Parse(Console.ReadLine());
        Console.WriteLine(PREFIX +"city:");
        string city = Console.ReadLine();

        // Create the person
        Person person = new Person(name, age, city); 

        // Write the person information to the screen
        Console.WriteLine(person.GetName() + " aged " + person.GetAge() + " lives in " + person.GetCity() + ".");

        // Keep the following line intact 
        Console.WriteLine("===========================");
    }
}