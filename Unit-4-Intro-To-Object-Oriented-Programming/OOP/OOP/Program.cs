namespace OOP;

class Program
{
    // This is an application program
    //It instantiates and uses objects to perform processing
    // Every application has exactly one method called Main()
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        //Instatiate (define) a Student class object
        // A class is a data type
        // Define an object of a class like any other variable w/a slight difference
        
        //data-type name = initializer; int sum = 0;
        
        // A class is instantiated with the new keyword
        //      is initiazed using one of its constructors
        //className name  new className(initizalizers);
        
        //We need to be sure we have all the data we want to store in our object
        // Before we instantiate the object

        List<int> scores = new List<int>();
        scores.Add(100);
        scores.Add(90);
        scores.Add(80);
    // Instantiate a Student using the data we wante to store in the Student object
        Student aStudent = new Student("Frank", scores);
        
        // Display the Student object we created 
        // Console.WrriteLine() does not know how to display an object of our class
        
        /*
         * Use the student class method to display Student class object
         *
         * object.method() < ---- Objected oriented notations
         */

        aStudent.ShowStudent();
    }
}