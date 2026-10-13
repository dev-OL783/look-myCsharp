namespace PodCastWorld
{
    public static class UserMenu
    {
        public static void Show(User user)
        {
            bool loggedIn = true;

            while (loggedIn)
            {
                Console.WriteLine("\n=== User Menu ===");
                Console.WriteLine("1. View Details");
                Console.WriteLine("2. Change Password");
                Console.WriteLine("3. Logout");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        ViewDetails(user);
                        break;

                    case "2":
                        ChangePassword(user);
                        break;

                    case "3":
                        Console.WriteLine("Logging out...");
                        loggedIn = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private static void ViewDetails(User user)
        {
            Console.WriteLine("\n=== User Details ===");
            Console.WriteLine($"Name: {user.GetName()}");
            Console.WriteLine($"Age: {user.GetAge()}");
            Console.WriteLine($"Email: {user.GetEmail()}");
            Console.WriteLine($"Mobile: {user.GetMobileNumber()}");
        }

        private static void ChangePassword(User user)
        {
            Console.WriteLine("Enter current password:");
            string currentPassword = Console.ReadLine() ?? "";

            if (currentPassword != user.GetPassword())
            {
                Console.WriteLine("Incorrect password.");
                return;
            }

            string newPassword;

            do
            {
                Console.WriteLine("Enter a new password:");
                newPassword = Console.ReadLine() ?? "";

                if (!UserValidator.IsValidPassword(newPassword))
                {
                    Console.WriteLine(
                        UserValidator.GetPasswordError(newPassword));
                }

            } while (!UserValidator.IsValidPassword(newPassword));

            user.SetPassword(newPassword);

            Console.WriteLine("Password updated successfully.");
        }
    }
}


// namespace PodCastWorld;
// // public class UserMenu
// public static void UserMenu()
// {
//     bool loggedIn = true;

//     while (loggedIn)
//     {
//         Console.WriteLine("\n=== User Menu ===");
//         Console.WriteLine("1. View Details");
//         Console.WriteLine("2. Change Password");
//         Console.WriteLine("3. Logout");

//         string choice = Console.ReadLine() ?? "";

//         switch (choice)
//         {
//             case "1":
//                 ViewUserDetails();
//                 break;

//             case "2":
//                 ChangePassword();
//                 break;

//             case "3":
//                 Console.WriteLine("Logging out...");
//                 loggedIn = false;
//                 break;

//             default:
//                 Console.WriteLine("Invalid option.");
//                 break;
//         }
//     }
// }

// public static void ViewUserDetails()
// {
//     Console.WriteLine("\n=== User Details ===");
//     Console.WriteLine($"Name: {currentUser.GetName()}");
//     Console.WriteLine($"Age: {currentUser.GetAge()}");
//     Console.WriteLine($"Email: {currentUser.GetEmail()}");
//     Console.WriteLine($"Mobile: {currentUser.GetMobile()}");
// }

// public static void ChangePassword()
// {
//     Console.WriteLine("\nEnter your current password:");
//     string currentPassword = Console.ReadLine() ?? "";

//     if (currentPassword != currentUser.GetPassword())
//     {
//         Console.WriteLine("Incorrect password.");
//         return;
//     }

//     string newPassword;

//     do
//     {
//         Console.WriteLine("Enter a new password:");
//         newPassword = Console.ReadLine() ?? "";

//         if (!UserValidator.IsValidPassword(newPassword))
//         {
//             Console.WriteLine(
//                 UserValidator.GetPasswordError(newPassword));
//         }

//     } while (!UserValidator.IsValidPassword(newPassword));

//     currentUser.SetPassword(newPassword);

//     Console.WriteLine("Password changed successfully.");
// }



// using PodCastWorld.Models;
// using PodCastWorld.Services;
