namespace SampleOOPApplication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person aPerson = new Person("John", 70, 250, "M");
        Console.WriteLine($"{aPerson}");
    }
}