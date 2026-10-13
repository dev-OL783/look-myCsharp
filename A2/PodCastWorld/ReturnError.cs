// using System.Linq;
// using System.Text.RegularExpressions;

// public static class UserValidator
// {
//     // Existing IsValid methods...

//     public static string GetNameError(string name)
//     {
//         if (string.IsNullOrWhiteSpace(name))
//             return "Name cannot be empty.";

//         if (!Regex.IsMatch(name, @"^(?=.*[A-Za-z])[A-Za-z .'-]+$"))
//             return "Name may only contain letters, spaces, apostrophes ('), full stops (.) and hyphens (-).";

//         return "";
//     }

//     public static string GetAgeError(string ageInput)
//     {
//         if (!int.TryParse(ageInput, out int age))
//             return "Age must be a whole number.";

//         if (age < 18 || age > 99)
//             return "Age must be between 18 and 99.";

//         return "";
//     }

//     public static string GetMobileError(string mobile)
//     {
//         if (string.IsNullOrWhiteSpace(mobile))
//             return "Mobile number cannot be empty.";

//         if (mobile.Length != 10)
//             return "Mobile number must be exactly 10 digits.";

//         if (!mobile.StartsWith("0"))
//             return "Mobile number must start with 0.";

//         if (!mobile.All(char.IsDigit))
//             return "Mobile number can only contain digits.";

//         return "";
//     }

//     public static string GetEmailError(string email)
//     {
//         if (string.IsNullOrWhiteSpace(email))
//             return "Email cannot be empty.";

//         int atCount = email.Count(c => c == '@');

//         if (atCount != 1)
//             return "Email must contain exactly one '@' symbol.";

//         string[] parts = email.Split('@');

//         if (parts[0].Length == 0 || parts[1].Length == 0)
//             return "Email must contain characters on both sides of '@'.";

//         return "";
//     }

//     public static string GetPasswordError(string password)
//     {
//         if (string.IsNullOrWhiteSpace(password))
//             return "Password cannot be empty.";

//         if (password.Length < 8)
//             return "Password must be at least 8 characters long.";

//         if (!password.Any(char.IsUpper))
//             return "Password must contain at least one uppercase letter.";

//         if (!password.Any(char.IsLower))
//             return "Password must contain at least one lowercase letter.";

//         if (!password.Any(char.IsDigit))
//             return "Password must contain at least one number.";

//         return "";
//     }
// }