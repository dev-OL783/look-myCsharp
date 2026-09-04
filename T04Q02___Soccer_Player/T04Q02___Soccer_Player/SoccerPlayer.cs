namespace T04Q02___Soccer_Player;

/// <summary>
/// This class represents a soccer player. It contains fields that represents a
/// player's physical attributes, their club and their performance. 
/// </summary>
public class SoccerPlayer
{

    // Add the fields
    private string _name;
    private int _age;
    private string _club;
    private int _shirtNumber;
    private int _gamesPlayed;
    private int _goals;
    private int _assists;
    
    /// <summary>
    /// The soccer player's constructor for a player who hasn't played a game. 
    /// The player's games played, goals and assists will be set to 0.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <param name="club"></param>
    /// <param name="shirtNumber"></param>
    public SoccerPlayer(string name, int age, string club, int shirtNumber)
    {
        // Add the initialisations
        _name = name;
        _age = age;
        _club = club;
        _shirtNumber = shirtNumber;
        _gamesPlayed = 0;
        _goals = 0;
        _assists = 0;
    }

    /// <summary>
    /// The soccer player's constructor for a player who has played a game. 
    /// </summary>
    /// <param name="name">The soccer player's name.</param>
    /// <param name="age">The soccer player's age.</param>
    /// <param name="club">The soccer player's club.</param>
    /// <param name="shirtNumber">The soccer player's shirt number.</param>
    /// <param name="gamesPlayed">The number of games that the soccer player's has played.</param>
    /// <param name="goalsScored">The soccer player's goals scored.</param>
    /// <param name="assists">The soccer player's goal assists.</param>
    public SoccerPlayer(string name, int age, string club, int shirtNumber, int gamesPlayed, int goals, int assists)
    {
        // Add the initialisations
        _name = name;
        _age = age;
        _club = club;
        _shirtNumber = shirtNumber;
        _gamesPlayed = gamesPlayed;
        _goals = goals;
        _assists = assists;
    }

    /// <summary>
    /// A method to share the soccer players information.
    /// </summary>
    /// <returns>A formatted string that will return the player's information.</returns>
    public string GetDetails()
    {
        // Replace with the correct code
        // return "Name: " + _name + "\n"
        //        + "Age: " + _age + "\n"
        //        + "Club: " + _club + "\n"
        //        + "Shirt Number: " + _shirtNumber + "\n"
        //        + "Games Played: " + _gamesPlayed + "\n"
        //        + "Goals: " + _goals + "\n"
        //        + "Assists: " + _assists;
        return "Name: " + _name + '\n'
               + "Age: " + _age + '\n'
               + "Club: " + _club + '\n' 
               + "Shirt Number: " + _shirtNumber + '\n'
               + "Games Played: " + _gamesPlayed + '\n'
               + "Goals: " + _goals + '\n'
               + "Assists: " + _assists;
    }
}   