namespace T02Q04___Grade_Description;

class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Get the grade code from the user
        const string PROMPT = "Please enter the grade code, an integer between 1 and 7:";
        const string OUT_FORMAT = "Grade code {0} is classified as '{1}'.";
        Console.WriteLine(PROMPT);
        string userInput = Console.ReadLine();
        int gradeCode = int.Parse(userInput);

        string description = "";

        switch (gradeCode)
        {
            // Insert your solution here:
            // Complete the switch statement to assign the appropriate value 
            // to description.
            //
            // Do not attempt to replace the switch statement with any other
            // construct - if, while, and for are prohibited for this exercise
                case 1:
                    // Console.WriteLine("Low Fail");
                    description = "Low Fail";
                    break;            
                case 2:
                    description = "Fail";
                    break;
                case 3:
                    description = "Marginal Fail";
                    break;
                case 4:
                    description = "Pass";
                    break;
                case 5:
                    description = "Credit";
                    break;
                case 6:
                    description = "Distinction";
                    break;
                case 7:
                    description = "High Distinction";
                    break;
                default:
                    description = "Invalid";
                    break;
        }

            // Keep the following line intact
        Console.WriteLine(OUT_FORMAT, gradeCode, description);
        Console.WriteLine("===========================");
    }
}
