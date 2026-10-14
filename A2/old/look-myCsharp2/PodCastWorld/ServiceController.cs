// namespace PodCastWorld;

// class registrationController

// {
//     public static void RegisterRegUser()
//         {
//             const string PREFIX = "Please enter your ";
//             string name;
//             int age;
//             string email;
//             string mobile;
//             string password;
            
//             Console.WriteLine("Registering as a regular listener.");

//             // NAME
//             while (true)
//             {
//                 Console.WriteLine(PREFIX + "name:");
//                 name = Console.ReadLine() ?? "";

//                 if (UserValidator.IsValidName(name))
//                     break;

//                 UserValidator.PrintNameError();
//             }

//             // AGE
//             while (true)
//             {
//                 Console.WriteLine(PREFIX + "age:");

//                 if (UserValidator.IsValidAge(Console.ReadLine() ?? "", out age))
//                     break;

//                 UserValidator.PrintAgeError();
//             }

//             // EMAIL
//             while (true)
//             {
//                 Console.WriteLine(PREFIX + "email:");
//                 email = Console.ReadLine() ?? "";

//                 if (UserValidator.IsValidEmail(email))
//                     break;

//                 UserValidator.PrintEmailError();
//             }

//             // MOBILE
//             while (true)
//             {
//                 Console.WriteLine(PREFIX + "mobile number:");
//                 mobile = Console.ReadLine() ?? "";

//                 if (UserValidator.IsValidMobile(mobile))
//                     break;

//                 UserValidator.PrintMobileError();
//             }

//             // PASSWORD
//             while (true)
//             {
//                 Console.WriteLine(PREFIX + "password:");
//                 password = Console.ReadLine() ?? "";

//                 if (UserValidator.IsValidPassword(password))
//                     break;

//                 UserValidator.PrintPasswordError();
//             }
            

//             // Store temporarily in memory
//             currentUser = new User(
//                 name,
//                 age,
//                 email,
//                 mobile,
//                 password);

//             Console.WriteLine("\nRegistration successful!");
//             // Congratulations ${user}. You have registered as a regular listener.
//         }
// }