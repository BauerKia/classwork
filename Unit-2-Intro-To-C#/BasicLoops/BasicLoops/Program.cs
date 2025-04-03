namespace BasicLoops;

class Program
{
    static void Main(string[] args)
    {
        
        /*
         * Problem 1
         */
        string input = "";
        do
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Would you like to continue (y/n)?");
             input = Console.ReadLine();
        } while (input == "y");
Console.WriteLine("Goodbye!");

/*
 * Problem 2
 */
Console.WriteLine("Would you like to continue (y/n)?");
input = Console.ReadLine();
