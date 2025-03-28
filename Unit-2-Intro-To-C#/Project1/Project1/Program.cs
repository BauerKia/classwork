/*
 * This is a block comment - everything between the slash-*
 *  and *-slash is ignored
 *
 *  The * at the start of each line is optional
 */

// A namespace identifies a context in which a word is known
// allows the same name to be used in different contexts to mena different things 
namespace Project1;

// everything in C# is defined in a Class
// A Class is a group of related things
// A Class starts with the class keyword
class Program

// {} surround blocks of related code aka code-blocks
{ // Start of code for the class
    // Every application has a program called Main()
    // A method is a self-contained set code that performs a functions
    // aka: a function or a program
    // a method may return a value and accept data to process
    // Method signature identifies wha the method returns it's name and what it accepts
    //return-type name(data-it-accepts)
    
    //Main() is where every application starts 
    //Every application has one and only Main() method
    
    //Below Main() is a method that returns void and accepts string[] called args
    
    //return
    //     type name(data-it-accepts)
    
    static void Main(string[] args) // method signature
    { // Start of the code for Main()
        //This code will display what ever is between the ("") on the screen
        
        //Console is an object defined by C# to represent the screen
        // An object has certain behviors
        // A behavior is something an object can do with data
        // Behaviors are implemented using methods
        
        // object.method(data) - object oriented programmming
        
        
        //When you see a . after a name, the name too left of the . is probably an object
        // When you see name() the name is a method
        // When you see a .name , the name is usually method
        // object.method(data-for-the-method-to-process)
        
        
        Console.WriteLine("Hello, World!");
        
        
        
    } // End of code for Main()
}
// End of code for the Class