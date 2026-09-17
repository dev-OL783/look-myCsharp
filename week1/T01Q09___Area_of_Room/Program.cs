namespace T01Q09___Area_of_Room;

class Program
{
    static void Main(string[] args)
    {

        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        Console.WriteLine("Please enter the width of the room, in metres: ");
        double width = Convert.ToDouble(Console.ReadLine());
        

        Console.WriteLine("Please enter the length of the room, in metres:");
        double length = Convert.ToDouble(Console.ReadLine());
        
        double area = length * width;


        Console.WriteLine(area);

        // Keep the following line intact 
        Console.WriteLine("===========================");
    }
}