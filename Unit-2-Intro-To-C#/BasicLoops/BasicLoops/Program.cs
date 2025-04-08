using System.Diagnostics;
using System.Numerics;

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
        string newInput = "";
        do
        {
            Console.WriteLine("Please Enter a number:");
            int inputNum = int.Parse(Console.ReadLine());
         // call method
         numInLine(inputNum);
         
            Console.WriteLine("Would you like to continue (y/n)?");
            newInput = Console.ReadLine();
        } while (newInput == "y");

        Console.WriteLine("Goodbye!");
        
        
        /*
         *  Problem 3
         */
        int correctPW = 13579;
        Console.WriteLine("Please enter code: ");
        int inputPW = int.Parse(Console.ReadLine());
        while (inputPW != correctPW)
        {
            Console.WriteLine("Please enter correct code: ");
            inputPW = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Welcome Back to Your Humble Abode");
        
        /*
         * 
         */
        

    }

    static void numInLine(int num)
    { 
        //Trying to get an array to return
        //or have the console print both there and back numbers  when method is called
        string one = "";
        string two = "";
        for (int i = num; i >= 0; i--)
        {

            one = one + i.ToString();
        }
        Console.WriteLine($"{one}");
        for (int i = 0; i <= num; i++)
        {
            two = two + i.ToString(); 
        }
        Console.WriteLine($"{two}");

    }
    


}

