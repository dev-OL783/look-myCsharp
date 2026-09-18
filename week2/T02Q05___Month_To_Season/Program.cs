namespace T02Q05___Month_To_Season;

class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");
           
        // Ask for and convert the month number 
        const string PROMPT = "Enter a month between 1 and 12:";
        const string line = "The season for month '{0}' is '{1}'.";
        Console.WriteLine(PROMPT);
        sbyte month = sbyte.Parse(Console.ReadLine());
        string convert = "";
        // int result = int.Parse(month);
        // Convert month to season

        // Insert your solution here.

        switch (month)
        {
                case 1:
                    // Console.WriteLine("Low Fail");
                    convert = "Summer";
                    break;            
                case 2:
                    convert = "Summer";
                    break;
                case 3:
                    convert = "Autumn";
                    break;
                case 4:
                    convert = "Autumn";
                    break;
                case 5:
                    convert = "Autumn";
                    break;
                case 6:
                    convert = "Winter";
                    break;
                case 7:
                    convert = "Winter";
                    break;
                case 8:
                    convert = "Winter";
                    break;
                case 9:
                    convert = "Spring";
                    break;
                case 10:
                    convert = "Spring";
                    break;
                case 11:
                    convert = "Spring";
                    break;
                case 12:
                    convert = "Summer";
                    break;
                default:
                    convert = "Invalid";
                    break;
        }

        Console.WriteLine(line, month, convert);

        // Keep the following line intact
        Console.WriteLine("===========================");
    }
} 