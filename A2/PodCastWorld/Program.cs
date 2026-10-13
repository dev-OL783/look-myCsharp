namespace PodCastWorld
{
    class Program
    {
        // Constants
        const string GOODBYE = "Goodbye!"; // not useful currently
        const string PREFIX = "Please enter your ";

        private static User? currentUser;  // once the program ends, user data gets wiped
        
        static void Main(string[] args)
        {   // greeter
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("Welcome to PodCastWorld!");
            Console.WriteLine();
            Console.WriteLine("============================================\n");
            //
            bool keepGoing = true;

            while (keepGoing)
            {
                PrintMainMenu();

                // Read and trim the input (handles accidental leading/trailing spaces)
                string choice = (Console.ReadLine() ?? string.Empty).Trim();

                switch (choice)
                {
                    case "1":
                        // UserAuthenticator.cs
                        UserLogin();
                        break;

                    case "2":
                        // Jump directly into the registration flow
                        RegisterUser(); // UserValidator.cs
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
            string name;
            int age;
            string email;
            string mobile;
            string password;

            // NAME
            while (true)
            {
                Console.WriteLine(PREFIX + "name:");
                name = Console.ReadLine() ?? "";

                if (UserValidator.IsValidName(name))
                    break;

                UserValidator.PrintNameError();
            }

            // AGE
            while (true)
            {
                Console.WriteLine(PREFIX + "age:");

                if (UserValidator.IsValidAge(Console.ReadLine() ?? "", out age))
                    break;

                UserValidator.PrintAgeError();
            }

            // EMAIL
            while (true)
            {
                Console.WriteLine(PREFIX + "email:");
                email = Console.ReadLine() ?? "";

                if (UserValidator.IsValidEmail(email))
                    break;

                UserValidator.PrintEmailError();
            }

            // MOBILE
            while (true)
            {
                Console.WriteLine(PREFIX + "mobile number:");
                mobile = Console.ReadLine() ?? "";

                if (UserValidator.IsValidMobile(mobile))
                    break;

                UserValidator.PrintMobileError();
            }

            // PASSWORD
            while (true)
            {
                Console.WriteLine(PREFIX + "password:");
                password = Console.ReadLine() ?? "";

                if (UserValidator.IsValidPassword(password))
                    break;

                UserValidator.PrintPasswordError();
            }

            

            // Store temporarily in memory
            currentUser = new User(
                name,
                age,
                email,
                mobile,
                password);

            Console.WriteLine("\nRegistration successful!");
        }


        public static void UserLogin()
        {
            Console.WriteLine("\nLogin");

            if (currentUser == null)
            {
                Console.WriteLine("No user has been registered yet.");
                return;
            }

            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine() ?? "";

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine() ?? "";

            bool authenticated =
                UserAuthentication.Authenticate(currentUser, email, password);

            // if (authenticated)
            // {
            //     Console.WriteLine($"Welcome back, {currentUser.GetName()}!");
                
            //     UserMenu();
            // }
            if (authenticated)
            {
                Console.WriteLine($"Welcome back, {currentUser.GetName()}!");
                UserMenu.Show(currentUser);
            }
            else
            {
                Console.WriteLine("Invalid email or password.");
            }
        }
    }
}