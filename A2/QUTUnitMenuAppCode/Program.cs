namespace QUTUnitMenuApp;

/// <summary>
/// The entry point for the the program.
/// 
/// The program will allow the user to create and administrate a QUT unit.
/// 
/// RESPONSIBILITY: The program's entry point. 
/// </summary>
public class Program
{
    /// <summary>
    /// The main program.
    /// </summary>
    /// <param name="args">An array of command line arguments. Not used.</param>
    static void Main(string[] args)
    {
       // creates the menu and runs it
        QUTController app = new QUTController();
        app.Run();
    }
}
