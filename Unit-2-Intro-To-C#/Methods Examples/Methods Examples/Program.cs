namespace Methods_Examples;

class Program
{
    /*************************************************
     *  Demonstrate the use of Programmer defined methods
     *  a method is a program that process data and usually returns a value
     *
     *  a method starts with a method signature:
     *                  - Identifies the name of the method
     *                  - What type of data it returns
     *                  - What data it will accept for processing
     * Method Signature:    return-type Name(data-it-will-accept)
     *
     *      return-type - the type of data returned fro mthe method
     *                      use void if the method does not return data
     *
     *      Name() - Name of the method - method names are in PascalCase
     *                                                PascalCase - the first letter of every word is capitalized
     * STICK TO THE STANDARD CODING RULES
     *      (data-it-will-accept) - data-type and name of any parameters
     * '
     *       parameter is a piece of data passed/given to a method for its processing
     *************************************/
    
    // Main() method signature
    
    // static - indicates there can be only one of these in an application ( We need it but it is not a part of the method signature)
    
    //        return  
    //        type  name(parameters-it-may-accept)
    static void Main(string[] args) // Main is a method that returns nothing and recieves String[]
    {
        Console.WriteLine("Hello, World!");

        int mySum = Addem(1, 2); // Send the numbers 1 and 2 to get the sum
                                            //Addem() will be executed with the numbers 1 and 2
                                            //it will return the sum
                                            //which will be stored in the variable mySum
        Console.WriteLine("The sum of 1 and 2 is:" + mySum);
        
    } // End of Main()
    
    // After a method you may define other methods that method can use
    // "Helper Methods" - help a method to do/perform a specific task
    
    //Define a method to  recieve two numbers and return the sum
    //If a method will be used be a static method, it must be static itself
    // Any method used by Main() must be static
    
    // return
    //type name(parameters)
   static int Addem(int num1, int num2)
    {
        return num1 + num2; // Add the two parameters and return the sum 

    }
}