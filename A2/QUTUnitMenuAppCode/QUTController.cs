namespace QUTUnitMenuApp;

/// <summary>
/// A class that controls the rest of the program. It will act as a
/// intermediary to the user interface and the backend data.
///
/// RESPONSIBILITY: Controls the program via connecting the UI with the backend. 
/// </summary>
public class QUTController
{
    /// <summary>
    /// An instance of a QUT unit (the model). 
    /// </summary>
    private QUTUnit? unit;

    /// <summary>
    /// An instance of a menu (part of the view)
    /// </summary>
    private QUTMenu menu;

    /// <summary>
    /// The constructor for the class.
    /// </summary>
    public QUTController()
    {
        unit = null;
        menu = new QUTMenu();
    }

    /// <summary>
    /// Runs the program.
    /// </summary>
    public void Run()
    {
        menu.DisplayHeader();
        bool keepGoing = true;
        // Keep running the menu until the user chooses to exit the program
        // This will be when the user selects exit in the DisplayMainMenu method
        while (keepGoing)
        {
            keepGoing = ProcessMainMenu();
        }
    }

    /// <summary>
    /// Processes the main menu. It will print out the main menu to the UI and the
    /// act on the user input. The statements will loop until the user chooses to exit.  
    /// </summary>
    /// <returns>TRUE if the user chooses to exit, otherwise FALSE</returns>
    public bool ProcessMainMenu()
    {                       
        // Create the display strings and list
        const string CREATEUNIT_STR = "Create the unit";//  Menu option 1   
        const string ADMINSTRATE_STR = "Administrate the unit"; // Menu option 2
        const string EXIT_STR = "Exit"; // Menu option 3

        List<string> options = new List<string>();
        options.Add(CREATEUNIT_STR);
        options.Add(ADMINSTRATE_STR);
        options.Add(EXIT_STR);

        // int for each option above needed for the switch statement
        const int CREATEUNIT_INT = 0, ADMINISTRATE_INT = 1, EXIT = 2;
            
        // Display the main menu and get back an option
        int option = menu.DisplayMainMenu(options);

        // Make selection on user input from the CmdLineUI.GetOption method
        switch (option)
        {
            // Both the CreateUnitMenu and the CreateUnitMenu return the value of 'true'
            // The return value is unused at the moment but could be used in the program expands  
            case CREATEUNIT_INT: // If user choses 1 then proceed to the progress to ProcessUnitMenu
                ProcessCreateUnit();
                break;
            case ADMINISTRATE_INT: // If user choses 2 then proceed to the AdministrateUnit
                ProcessAdministrateUnit();
                break;
            case EXIT:
                menu.DisplayMessage("Exiting");
                return false; // Return false to the Run method, this will stop the loop and will ultimately exit the program 
                break;
            default:
                menu.DisplayError("Wrong main menu choice");
                break;
        }
        // Both the CreateUnitMenu amd the AdministrateUnit will break from the switch 
        // statement and will then return true. This will mean that the loop in the 
        // Run method will keep displaying the main menu
        return true;
    }

    /// <summary>
    /// Processes the task of creating a unit.
    /// </summary>
    private void ProcessCreateUnit()
    {
        string code, name;
        int initial;
        DateTime first, last;

        // Display the create unit menu 
        menu.CreateUnitMenu(out code, out name, out initial, out first, out  last);
        unit = new QUTUnit(code, name, initial, first, last);
        menu.DisplayUnitCreation(unit);
    }


    /// <summary>
    /// Processes the task of administrating a unit.
    /// </summary>
    /// <returns>TRUE if the user chooses to return to the previous menu, otherwise FALSE.</returns>
    private bool ProcessAdministrateUnit()
    {
        // A control variable to need to menu running
        bool keepGoingAdmin = true;

        //  You could move this string to after the class declaration because it is used in more than 1 method
        const string CREATEUNIT_STR = "Create the unit";

        // If the unit has been assigned then generate a error
        if (unit == null)
        {
            menu.DisplayError($"The unit has not been created. Please choose \"{CREATEUNIT_STR}\" first");
            return false;
        }
        else
        {
            // Keep going with the administration unit menu until the user chooses to
            // return to the previous menu. In this case the previous menu will be the
            // main menu
            while (keepGoingAdmin)
            {
                keepGoingAdmin = AdministrateUnitOptions();
            }

        }
        return keepGoingAdmin; // should be false

    }


    /// <summary>
    /// A menu that allows to user to interact with the user.
    /// </summary>
    /// <returns>FALSE is an error is generate, otherwise TRUE.</returns>
    private bool AdministrateUnitOptions()
    {

        // As before add the string and list 
        const string DISPLAY_STR = "Display the unit details"; // Option 1
        const string ADD_STR = "Add students"; // Option 2
        const string REMOVE_STR = "Remove students"; // Option 3
        const string ANOTHER_STR = "Another menu"; // Option 4
        const string RETURN_STR = "Return to first menu"; // Option 5

        // create ints for the switch statement below
        const int DISPLAY_INT = 0, ADD_INT = 1, REMOVE_INT = 2, ANOTHER_INT = 3, RETURN_INT = 4;

        List<string> options = new List<string>();
        options.Add(DISPLAY_STR);
        options.Add(ADD_STR);  
        options.Add(REMOVE_STR);  
        options.Add(ANOTHER_STR);
        options.Add(RETURN_STR);

        // Display the main menu and get back an option
        int option = menu.DisplayAdministrateUnitMenu(options);

        // Make selection on user input from the CmdLineUI.GetOption method
        switch (option)
        {
            case DISPLAY_INT:
                menu.DisplayUnitDetails(unit);
                break;
            case ADD_INT:
                AddStudentsToUnit();
                break;
            case REMOVE_INT:
                RemoveStudentsFromUnit();
                break;
            case ANOTHER_INT:
                // This will exit the method rather than existing the switch statement
                // False will be returned, so the ProcessAdministrateUnit loop
                // will be exited 
                bool choice = ProcessAnotherMenu();
                return choice;
                break;
            case RETURN_INT:
                // False will be returned, so the ProcessAdministrateUnit loop
                // will be exited 
                return false;
                break;
            default:
                CmdLineUI.DisplayError("Wrong administration menu choice");
                break;
        }
        // The DisplayUnitDetails, AddStudentsToUnit, RemoveStudentsFromUnit will
        // all break the switch statement and return true
        return true;

    }


    /// <summary>
    /// Allows the user to add students to the unit.
    /// </summary>
    /// <returns>TRUE</returns>
    private bool AddStudentsToUnit()
    {
        int moreStudents = menu.GetMoreStudents();
        unit.IncreaseStudents(moreStudents);
        menu.DisplayMessage($"{moreStudents} students have been added.");
        return true;
    }

    /// <summary>
    /// Allows the user to remove students from the unit
    /// </summary>
    /// <returns>TRUE</returns>
    private bool RemoveStudentsFromUnit()
    {
        int lessStudents = menu.GetLessStudents(); 
        unit.DecreaseStudents(lessStudents);
        menu.DisplayMessage($"{lessStudents} students have been removed.");
        return true;
    }


    /// <summary>
    /// An example of another menu. Where use can return to the previous menu
    /// or return to the first menu.
    /// </summary>
    /// <returns>TRUE to return to the previous menu
    ///           FALSE to return to the previous-previous menu</returns>
    private bool ProcessAnotherMenu()
    {

        // As before add the string and list 
        const string PREVIOUS_STR = "Return to previous menu"; // Option 2
        const string PRE_PREVIOUS_STR = "Return to previous-previous (first) menu"; // Option 2

        List<string> options = new List<string>();
        options.Add(PREVIOUS_STR );
        options.Add(PRE_PREVIOUS_STR );

        const int PREVIOUS_INT = 0, PRE_PREVIOUS_INT = 1;

        int option = menu.DisplayAnotherMenu(options);

        switch (option)
        {
            case PREVIOUS_INT:
                return true;
                break;
            case PRE_PREVIOUS_INT:
                return false;
                break;
            default:
                CmdLineUI.DisplayError("Wrong another menu choice");
                break;
        }
        return true;
    }
}