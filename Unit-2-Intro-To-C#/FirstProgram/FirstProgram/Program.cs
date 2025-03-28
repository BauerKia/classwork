namespace FirstProgram;
// This program will ask for three numbers
// add them together and display

/* *****Programming is coming up with the solution****
* Think like a human first! Coder Second!
* Coding is writing that solution into a language
*/

//Programming Solution - Human Thinking
//Identify the detaileds steps

//Ask for the numbers -> one at a time
// -> Write down each number as its given
// Add the numbers together -> create a sum/total
// Say the total (display)


// Now that we have the steps in our solution
//Identify any data you need for the steps

// 1. A place to write down each number -> A variable in a program
// 2. A place to hold the sum/total -> A variable in a program
// 3. A way to ask for the numbers -> A method in a program (object.method() )
// 4. A way to receive the numbers -> A method in a program (object.method() )
// A way to report the sum/total -> A method in a program (object.method() )

// Place the steps in the order we need to solve the program and add more details if necessary 
/*
 * 1. Ask for the numbers one at a time
 *          a.Tell whoever is giving us the numbers to give me the first number
 *          b. Receive the first number from the sender
 *          c. Write down the first number
 * Repeat two more times
 */
class Program
{
    static void Main(string[] args)
    {
        // Variable names C# are usually in camelCase
        // Its always good to initialize variables when defing them so you know what is in them
        
        Console.WriteLine("--- Starting program ---");
            //Define three numbers
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            
            //Define a var to hold the bum of the numbers
            int sum = 0;
            
            //Ask for the nums one at a time using the C# Console object
            // which represents the keyboard and screen
            
            Console.WriteLine("Give me a number: "); //Asking for the number
            string aLine;
            aLine = Console.ReadLine(); // Get a line from the keyboard
          //We need an int value to store our numbers
          // Console.ReadLine() only returns a string
          // So we need to convert the string from Console.ReadLine() to an int
          num1 = int.Parse(aLine);
          
          // Verify that I got the data expected
          // Display some words and the value I received
          //Little pieces + test them!
          
          Console.WriteLine("You entered: " + num1);
          Console.WriteLine("--- Ending program ---");
    }
}