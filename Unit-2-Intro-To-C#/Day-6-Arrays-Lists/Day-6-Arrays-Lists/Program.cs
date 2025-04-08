using System.Globalization;

namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define the variables to hold the numbers we need to add
        int number1 = 0; // Since we will be doing math it needs to be numeric
        int number2 = 0; // Since we will be doing math it needs to be numeric
        int number3 = 0; // Since we will be doing math it needs to be numeric

        // Define a variable to hold the sum of the numbers
        int sum = 0;
        // A for-loop is an excellent tool to process 
        //Define an array to hold 5 numbers
        // Make code that allows you to process changes  without changing too much
        int[] number = new int[3];

        Console.WriteLine("--- Starting program ---");

        // Ask for the numbers one at time using the C# Console object
        //     which represents the keyboard and screen
        // Console.ReadLine() returns a string from keyboard - cannot store in an int
        Console.WriteLine("Please enter a number:  "); // Asking for the number
        string theResponse; // Define a string to hold the line of input from the keyboard
        theResponse = Console.ReadLine(); // Get a line from the keyboard
      
        // int.Parse(string) will convert a string to an int
        number1 = int.Parse(theResponse);

        Console.WriteLine("Please enter a number:  ");
        theResponse = Console.ReadLine(); // Reuse theResponse define above
        number2 = int.Parse(theResponse);

        Console.WriteLine("Please enter a number:  ");
        theResponse = Console.ReadLine(); // Reuse theResponse define above
        number3 = int.Parse(theResponse);

        // Add the numbers together create a sum/total
        sum = number1 + number2 + number3;
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);

        // Tell the requester the average of the numbers
        //divides the sum by the number of elements ( arrayname.Length)
        
        //array
        
       
        
        // index        loop as
        // Start        long as the index       increment the
        //at 0          is not outside array    index for each loop
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine("Please enter a number: "); // ASking for a #
            number[i] = int.Parse(Console.ReadLine()); // get a string from keyboard
                                                                        // converst it to an int
                                                                        // store it in numbers
            Console.WriteLine("Element #" + i + " is: " + number[i]);
            sum = sum + number[i]; // add the correct number in the array to sum
        }
        
        //Verify the array received the numbers correctly
        // Go through the array one element at a time and display  the element
        // Note the cast of sum to a double so we get decimal places in the results
        Console.WriteLine("The average of the numbers is: " + (double)sum/number.Length);
        // sum / numbers.Length
        // int/ int ----> interger arithmetic - divide gives two parts: quotient and remainder
        //i int                         7/3 - qoutient = 2 remainder = 1
        
        // (double) sum/ number,Length
        //convert sum
        //to double  / int ----> floating point arithmetic
        //              /convert int to double (C# does this automatically)
        //              / double ---> floating point arithmetic
        //    double (2.33333)

        Console.WriteLine("--- Ending program ---");
    }
}