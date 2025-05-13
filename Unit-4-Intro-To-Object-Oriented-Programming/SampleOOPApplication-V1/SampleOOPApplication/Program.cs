namespace SampleOOPApplication;

class Program
{
    // Application program will define and mainpulate objects
    static void Main(string[] args)
    {
        Console.WriteLine("------ Start of Sample Object Oriented Application Made From Scratch -------");
        
        Person aPerson = new Person("John", 78, 250.6, 69, "Male");
        Console.WriteLine(aPerson);
        
        Person aPerson2 = new Person("John", 78, 250.6, 69, "Male");
Console.WriteLine(aPerson2);

        //if (aPerson == aPerson2) // == Compares the reference value (locations in memorY)
       if(aPerson.Equals(aPerson2)) // .Equals() SHOULD compare the content of the object -> But currently they are still not equal
        {
            Console.WriteLine("They are Equal");
        }
        else
        {
            Console.WriteLine("They are not eqaul");
        }

        Console.WriteLine("------ End of Sample Object Oriented Application Made From Scratch -------");
    } // End of Main()
}