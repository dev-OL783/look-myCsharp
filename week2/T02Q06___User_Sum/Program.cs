namespace T02Q06___User_Sum;

class Program
{
    static void Main(string[] args)
    {
        // Keep the following lines intact 
        Console.WriteLine( "===========================" );

        // Set initial values
        const int SENTINEL = 999;
        string PROMPT = $"Please enter {SENTINEL} to finish or another number to continue:";
        const string OUT_FORMAT = "The sum is {0}.";

        long runningTotal = 0;

        // Insert your solution here.
        while (true) {
            Console.WriteLine(PROMPT);
            string userInput = Console.ReadLine();

            if (userInput == SENTINEL.ToString()) break;

            int currentVal = Int32.Parse(userInput);
            runningTotal += currentVal;
            
        }

        // Display total
        Console.WriteLine( OUT_FORMAT, runningTotal );

        // Keep the following line intact
        Console.WriteLine( "===========================" );
    }
} 