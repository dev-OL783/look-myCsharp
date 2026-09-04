namespace T04Q02___Soccer_Player;

/// <summary>
/// The main class that executes the entire program. It will accept information 
/// from the user to produce a representation of a soccer player. 
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
        // Create the player
        SoccerPlayer player;

        // Get the information from input
        const string PREFIX = "Please enter the player's ";
        Console.WriteLine(PREFIX + "name:");
        string name = Console.ReadLine();
        Console.WriteLine(PREFIX + "age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PREFIX + "club:");
        string club = Console.ReadLine();
        Console.WriteLine(PREFIX + "shirt number:");
        int shirtNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PREFIX + "games played:");
        int gamesPlayed = Convert.ToInt32(Console.ReadLine());
        if(gamesPlayed > 0)
        {

            Console.WriteLine(PREFIX + "goals:");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PREFIX + "assists:");
            int assists = Convert.ToInt32(Console.ReadLine());

            // Initialise the player with the full set of values
            player = new SoccerPlayer(name, age, club, shirtNumber, gamesPlayed, goal, assists); 
        } else
        {

            // Initialise the player with the some default values
            player = new SoccerPlayer(name, age, club, shirtNumber); 

        }

        Console.WriteLine("------------");

        // Display the player's information to the console 
        Console.WriteLine(player.GetDetails());
        // Keep the following line intact 
        Console.WriteLine("===========================");
    }

}