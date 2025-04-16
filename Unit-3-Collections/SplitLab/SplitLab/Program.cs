namespace SplitLab;

class Program
{
    static void Main(string[] args)
    {

        string input = "";
        //Problem 1
        do
        {
            Console.WriteLine("Please enter a sentence: ");
            input = Console.ReadLine();

            string[] split = input.Split(' ');

            foreach (var word in split)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Do you want to continue? (y/n)");
            input = Console.ReadLine();
        } while (input == "y");
        
        Console.WriteLine("Goodbye!");
        
        
        // Problem 2
        string add = "";
        do
        {
            Console.WriteLine("Please enter some text: ");
            input = Console.ReadLine();
            
            add = add + " " + input;
                
            Console.WriteLine($"You have entered: {add}");
                
            Console.WriteLine("Do you want to continue? (y/n)");
            input = Console.ReadLine();
        } while (input == "y");
        
        Console.WriteLine("Goodbye!");
    }
}