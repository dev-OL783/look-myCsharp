namespace QUTUnitMenuApp;


/// <summary>
/// Presents a menu to the screen. This presents a high-level
/// view of input and output. Users will be presented with a
/// list of options, which will proceed to let them enter
/// in more detailed information.
/// 
/// RESPONSIBILITY: High-level user interaction.
/// </summary>
public class QUTMenu
{
      
    /// <summary>
    /// Displays the main heading.
    /// </summary>
    public void DisplayHeader()
    {
        CmdLineUI.DisplayString("-------------------");
        CmdLineUI.DisplayString("     QUT    Menu   ");
        CmdLineUI.DisplayString("-------------------");
    }

    /// <summary>
    /// Displays the main menu to the UI.
    /// </summary>
    /// <param name="options">A collection of options to present to the UI.</param>
    /// <returns>Returns the main menu option.
    public int DisplayMainMenu(List<string> options)
    {
        CmdLineUI.DisplayString();

        // The main menu strings 
        const string MAINMENU_STR = "Main Menu."; // Heading

        // Display the menu
        int option = GetOption(MAINMENU_STR, options);

        return option;
    }

    /// <summary>
    /// Gets information from a user
    /// </summary>
    /// </summary>
    /// <param name="code">The unit's code.</param>
    /// <param name="name">The unit's name.</param>
    /// <param name="initial">The unit's initial number of students.</param>
    /// <param name="first">The time/date of the first lecture.</param>
    /// <param name="last">The time/date of the last lecture.</param>
    public void CreateUnitMenu(out string code, out string name, out int initial, out DateTime first, out DateTime last)
    {
        // Get the information from the user 
        CmdLineUI.DisplayString("Enter the unit code:");
        code = CmdLineUI.GetString();
        CmdLineUI.DisplayString("Enter the unit name:");
        name = CmdLineUI.GetString();
        CmdLineUI.DisplayString("Enter the number of the initial students:");
        initial = CmdLineUI.GetInt();
        CmdLineUI.DisplayString($"Enter the time and date of the first lecture using '{QUTConsts.DATETIMEFORMAT}' format:");
        first = CmdLineUI.GetDateTime();
        CmdLineUI.DisplayString($"Enter the time and date of the last lecture using '{QUTConsts.DATETIMEFORMAT}' format:");
        last = CmdLineUI.GetDateTime();
        // All the parameters will be returned with there new values
    }

    /// <summary>
    /// Display to the user that the unit has been  created.
    /// </summary>
    /// <param name="unit">The unit to display information about.</param>
    public void DisplayUnitCreation(QUTUnit unit)
    {
        CmdLineUI.DisplayString("A new unit has been created.");
        CmdLineUI.DisplayString(unit);
    }

    /// <summary>
    /// Displays the administrate unit menu and receive input from the user.
    /// </summary>
    /// <param name="options">A collection of options to present to the UI.</param>
    /// <returns>Returns the administrate menu option.
    public int DisplayAdministrateUnitMenu(List<string> options)
    {
        CmdLineUI.DisplayString();  // Add a blank line for formatting
        const string ADMINMENU_STR = "Administrate unit menu."; // Heading
        int option = GetOption(ADMINMENU_STR, options);
        return option;
     }

    /// <summary>
    /// Displays the units details to UI.
    /// </summary>
    /// <param name="unit">The unit.</param>
    public void DisplayUnitDetails(QUTUnit unit)
    {
        CmdLineUI.DisplayString(unit);
    }

    /// <summary>
    /// Receives the number of new students to enroll in the unit.
    /// </summary>
    /// <returns>The number of new students to enroll in the unit.</returns>
    public int GetMoreStudents()
    {
        CmdLineUI.DisplayString("How many students to you want to add to the unit?");
        return CmdLineUI.GetInt();
    }

    /// <summary>
    /// Receives the number of new students to leave the unit.
    /// </summary>
    /// <returns>The number of new students to leave the unit.</returns>
    public int GetLessStudents()
    {
        CmdLineUI.DisplayString("How many students to you want to remove from the unit?");
        return CmdLineUI.GetInt();
    }

    /// <summary>
    /// Displays another menu.
    /// </summary>
    /// <param name="options">A collection of options to present to the UI.</param>
    /// <returns>Returns the another menu option.
    public int DisplayAnotherMenu(List<string> options)
    {
        CmdLineUI.DisplayString();  // Add a blank line for formatting

        // As before add the string and integers 
        const string ADMINMENU_STR = "Another menu"; // Heading
        int option = GetOption(ADMINMENU_STR, options);
            
         return option;

    }

    /// <summary>
    /// Displays a menu, with the options numbered from 1 to options.Length,
    /// the gets a validated integer in the range 1..options.Length. 
    /// Subtracts 1, then returns the result. If the supplied list of options 
    /// is empty, returns an error value (-1).
    /// </summary>
    /// <param name="title">A heading to display before the menu is listed.</param>
    /// <param name="options">The list of objects to be displayed.</param>
    /// <returns>Return value is either -1 (if no options are provided) or a 
    /// value in 0 .. (options.Length-1).</returns>
    public static int GetOption(string title, List<string> options)
    {
        // Defensive error checking - There should be at least 1 option, but we need double check.
        if (options.Count <= 0)
        {
            return -1;
        }

        // Setting up some formatting so the menu looks nice
        CmdLineUI.DisplayString(title);
        int digitsNeeded = (int)(1 + Math.Floor(Math.Log10(options.Count)));
        for (int i = 0; i < options.Count; i++)
        {
            CmdLineUI.DisplayString($"{(i + 1).ToString().PadLeft(digitsNeeded)}. {options[i]}");
        }

        // Highlighting the importance of diversity. The upper limit will depend of the number of elements passed.
        int option = CmdLineUI.GetInt($"Please enter a choice between 1 and {options.Count}.");

        // need to subtract 1 to align because programers count from zero 
        return option - 1;
    }

    /// <summary>
    /// Displays a string to the UI.
    /// </summary>
    /// <param name="str">The string to display.</param>
    public void DisplayMessage(string str)
    {
        CmdLineUI.DisplayString(str);
    }

    /// <summary>
    /// Displays an error to the UI.
    /// </summary>
    /// <param name="errStr">The string.</param>
    public void DisplayError(string errStr)
    {
        CmdLineUI.DisplayError(errStr);
    }

}
