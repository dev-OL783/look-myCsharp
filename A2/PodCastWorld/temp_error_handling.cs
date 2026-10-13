// public static void RegisterRegUser() // register users, requires Return Error.cs to do the checks
//         {
//             // Console.WriteLine(PREFIX + "name:");
//             // string name = Console.ReadLine(); // need to check for null/weird values
//             // Console.WriteLine(PREFIX + "age:");
//             // int age = Convert.ToInt32(Console.ReadLine());
//             // Console.WriteLine(PREFIX + "email:");
//             // string email = Console.ReadLine();
//             // Console.WriteLine(PREFIX + "mobile number:");
//             // int mobileNumber = Convert.ToInt32(Console.ReadLine());
//             // Console.WriteLine(PREFIX + "password:");
//             // string password = Console.ReadLine();
//             string name;
//             do
//             {
//                 Console.Write(PREFIX + "Name: ");
//                 name = Console.ReadLine();
//             }
//             while (!UserValidator.IsValidName(name)); // validator
//                 {
//                 Console.WriteLine(UserValidator.IsValidName(name));
//                 Console.Write("name: ");
//                 name = Console.ReadLine();
//                 } // error handling 

//             string ageInput;
//             do
//             {
//                 Console.Write(PREFIX + "Age: ");
//                 age = Console.ReadLine();
//             }
//             while (!UserValidator.IsValidAge(ageInput));
//                 {
//                 Console.WriteLine(UserValidator.GetAgeError(ageInput));
//                 Console.Write("Age: ");
//                 ageInput = Console.ReadLine();
//                 }

//             string mobile;
//             do
//             {
//                 Console.Write(PREFIX + "Mobile number: ");
//                 mobile = Console.ReadLine();
//             }
//             while (!UserValidator.IsValidMobile(mobile));
//                 {
//                 Console.WriteLine(UserValidator.GetMobileError(mobile));
//                 Console.Write("Mobile Number: ");
//                 mobile = Console.ReadLine();
//                 }

//             string email;
//             do
//             {
//                 Console.Write(PREFIX + "Email: ");
//                 email = Console.ReadLine();
//             }
//             while (!UserValidator.IsValidEmail(email));
//                 {
//                 Console.WriteLine(UserValidator.GetEmailError(password));
//                 Console.Write("email: ");
//                 password = Console.ReadLine();
//                 }

//             string password;
//             do
//             {
//                 Console.Write(PREFIX + "Password: ");
//                 password = Console.ReadLine();
//             }
//             while (!UserValidator.IsValidPassword(password));
//                 {
//                 Console.WriteLine(UserValidator.GetPasswordError(password));
//                 Console.Write("Password: ");
//                 password = Console.ReadLine();
//                 }
//         }