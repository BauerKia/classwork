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
         //n  Console.WriteLine(lineOfNum(inputNum));
         int[] newArray = new int[inputNum];
         int[] newArray2 = new int[inputNum];
         for (int i = inputNum; i <= inputNum && i !< 0; i--)
         {
             newArray[i] =  i;
             
         }
         Console.WriteLine($"{newArray}");
         for (int i = 0; i <= inputNum && i !> inputNum; i++)
         {
             newArray2[i] = i;
             
         }
         Console.WriteLine($"{newArray2}");
            Console.WriteLine("Would you like to continue (y/n)?");
            newInput = Console.ReadLine();
        } while (newInput == "y");

        Console.WriteLine("Goodbye!");
        
    }

    
    List<int> numList = new List<int>();
        for (int i = 0; i < inputNum; i++)
    {
        numList.Add(i);
    }

// You can convert it back to an array if you would like to
    int[] finalArray = numList.ToArray();


}

