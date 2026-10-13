namespace PodCastWorld
{
    class Program
    {
        // Constants
        const string GOODBYE = "Goodbye!";
        const string PREFIX = "Please enter your ";
        
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("Welcome to PodCastWorld!");
            Console.WriteLine();
            Console.WriteLine("============================================\n");

            bool keepGoing = true;

            while (keepGoing)
            {
                PrintMainMenu();

                // Read and trim the input (handles accidental leading/trailing spaces)
                string choice = (Console.ReadLine() ?? string.Empty).Trim();

                switch (choice)
                {
                    case "1":
                        // TODO: Add Login handling here
                        UserLogin();
                        break;

                    case "2":
                        // Jump directly into the registration flow
                        RegisterUser(); // DUMBASS WHY DID YOU PUT IN THE BLUDY CONSOLE.WRITELINE
                        break;

                    case "3":
                        Console.WriteLine(GOODBYE);
                        keepGoing = false;          // exit the loop
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Try again.\n");
                        break;
                }
            }
        }

        // ------------------------------------------------------------
        // Helper: show the main menu once per loop iteration
        // ------------------------------------------------------------
        static void PrintMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Please enter a choice:");
            Console.WriteLine("1. Login as a user.");
            Console.WriteLine("2. Register as a new user.");
            Console.WriteLine("3. Quit.\n");
            Console.WriteLine("Please enter a choice between 1 and 3: ");
        }

        // ------------------------------------------------------------
        // Registration routine – called when user selects “2”
        // ------------------------------------------------------------
        public static void RegisterUser()
        {
            Console.WriteLine("\nRegistration Menu");
            Console.WriteLine("Please enter your user type:\n");
            Console.WriteLine("1. Regular Listener.");
            Console.WriteLine("2. Premium Listener.");
            Console.WriteLine("3. Podcaster.\n");

            Console.WriteLine("Please enter a choice between 1 and 3: ");

            string choiceType = (Console.ReadLine() ?? string.Empty).Trim();

            switch (choiceType)
            {
                case "1":
                    RegisterRegUser();
                    break;
                case "2":
                    Console.WriteLine("Premium_User\n");
                    break;
                case "3":
                    Console.WriteLine("Podcast_User\n");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Try again.\n");
                    break;
            }

            // After registration you automatically return to the main menu
        }

        public static void RegisterRegUser()
        {
            Console.WriteLine(PREFIX + "name:");
            string name = Console.ReadLine(); // need to check for null/weird values
            Console.WriteLine(PREFIX + "age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PREFIX + "email:");
            string email = Console.ReadLine();
            Console.WriteLine(PREFIX + "mobile number:");
            int mobileNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PREFIX + "password:");
            string password = Console.ReadLine();
        }



        public static void UserLogin()
        {
            Console.WriteLine();
            // build in draft 4
        }
    }
}