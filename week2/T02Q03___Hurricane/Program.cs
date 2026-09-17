namespace T02Q03___Hurricane;

class Program
{
    static void Main(string[] args)
    {
        // Keep the following lines intact 
        Console.WriteLine( "===========================" );

        const string PROMPT = "Please enter the wind speed (km/h):";
        const string OUT_FORMAT = "If the wind speed is {0} then {1}.";

        // Get the wind speed
        Console.WriteLine( PROMPT );
        string? userInput = Console.ReadLine();

        // Convert the wind speed
        int windSpeed = int.Parse( userInput );

        string message = "";

        // Insert your solution here.
        // Display a suitable message derived from wind speed
        if (windSpeed < 0) {
            message = "null - ERROR: negative speed..";
        }
        else if (windSpeed > 0 && windSpeed < 118) {
            message = "the damage from winds is minimal";
        }
        else if (windSpeed >= 118 && windSpeed < 153) {
            message = "very dangerous winds will produce some damage";
        }
        else if (windSpeed >= 154 && windSpeed < 177) {
            message = "extremely dnagerous winds cause extensive damage";
        }
        else if (windSpeed >= 178 && windSpeed < 208) {
            message = "devastating damage will occur";
        }
        else if (windSpeed >= 209 && windSpeed < 251) {
            message = "catastrophic damage will occur";
        }
        else if (windSpeed >= 252) {
            message = "cataclysmic damage will occur";
        }
        else {
            message = "ERROR - please input a valid number";
        }

        // Keep the following lines intact
        Console.WriteLine( OUT_FORMAT, windSpeed, message );
        Console.WriteLine( "===========================" );
    }
}