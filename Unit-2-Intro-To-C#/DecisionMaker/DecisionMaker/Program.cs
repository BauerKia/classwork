namespace DecisionMaker;

class Program
{
    static void Main(string[] args)
    {
        // User Information pt1
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        
        
        Console.WriteLine($"{name}, Please enter a number between 1 and 100:");
        
        // Validation pt1
        int userNum =System.Math.Abs(int.Parse(Console.ReadLine()));
        Console.WriteLine($"{name}, you entered {userNum} which means your number is...");
        
        if (userNum % 2 == 0 && userNum < 60)
        {
            if (userNum > 60)
            {
                Console.WriteLine("Even and greater than 60.");
            } else if (userNum <= 60 && userNum >= 26)
            {
                Console.WriteLine("Even and between 26 and 60 inclusive.");
            }else if (userNum <= 24 && userNum >= 2)
            {
                Console.WriteLine("Even and less than 25");
            }
        } else if (userNum % 2 != 0)
        {
            if (userNum < 60)
            {
                Console.WriteLine("Odd and less than 60.");
            }else if (userNum > 60)
            {
                Console.WriteLine("Odd and greater than 60.");
            }
        }


    }
}