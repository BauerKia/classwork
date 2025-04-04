namespace StrinhsTest;

class Program
{
    static void Main(string[] args)
    {
        /***************************************************************************************************
         * Strings in C# are a special data type - they don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is:  1 1.24 "Bob"
         *
         * string variables sometimes require special processing
         *        you can't use < > to compare strings
         *        Beware: Early versions of C# do not allow use of == with strings
         *
         * C# provides several methods to operate on strings:
         *
         *     .Equals(string) - compare the string to left of the . to string inside () for equals
         *     .CompareTo(string) - return a number indicating how the first string relates to the second
         *                          return a negative number if first string is less than the second
         *                          return a zero if first string is equal the second
         *                          return a positive number if first string is greater than the second
         ***************************************************************************************************/
        // if (condition) {
        //    What to do if condition is true
        // }
        // else {
        //    What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine("string1 is: " + string1);
        Console.WriteLine("string2 is: " + string2);
        
        if (string1.CompareTo(string2) > 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }
        if (string1.CompareTo(string2) < 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT less than string2");
        }
        if (string1.CompareTo(string2) == 0) // if the first string is equal second string
        {
            Console.WriteLine("string1 is equal string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal string2");
        }
/*
 *
 *
 * 
 * Some methods that process strings
 * to see a list of all methods available to an object - just type objectName.
 * .Length - returns the number of character in a string
 *  .Contains(string) - returns true if the string given is inside a string
 *  .Substring(start-index.length) - extract characters
 *
 *  .EndsWith(string) - return true if string ends with the specified chars (case-sensitive)
 *
 *  .Trim() - remove any leading or trailing spaces ( Useful when getting data from users)
 */

// 0 123456789  1 123456789 2 123456789 3 123456789 4 1234567
      
        
        string sentence = "   My name is Kiana and I attempt C#   ";
        Console.WriteLine("There are" + sentence.Length + " characters in the sentence");

        //substring
        bool containsKiana = sentence.Contains("Kiana"); //true if sentence contains Kiana
        Console.WriteLine("Does sentence contain Kiana: " + containsKiana);
        
        Console.WriteLine("Does sentence start with My " + sentence.StartsWith("My"));
        Console.WriteLine("Does sentence start with My " + sentence.StartsWith("my"));
        Console.WriteLine("Does sentence start with My " + sentence.EndsWith("C#"));
        
        Console.WriteLine("Results when sentence.Trim() is used to remove leading and trailing spaces");
        Console.WriteLine("Does sentence start with My " + sentence.Trim().StartsWith("My"));
        Console.WriteLine("Does sentence start with My " + sentence.Trim().StartsWith("my"));
        Console.WriteLine("Does sentence start with My " + sentence.Trim().EndsWith("C#"));
        
       
        // When C# sees a statement with Chained Operations (operations separated by dots)
        // C# is going to process the statement fro mleft to right; one opertation at a time
        // Uses the result of operation in the next one
        // sentence.Trim().EndsWith(C#)
        
        // 1. sentence.Trim() -return a string with the leading and trailing spaces removed
        //2.  result-from-step-1.EndsWith() - return true or false depending on if string actually ends with chars 
        // internal new string
        
    } // End of Main()
}  // End of class Program
