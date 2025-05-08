namespace MovieLab;

class Program
{
    private List<Movie> movieList = new List<Movie>();
    
    static void Main(string[] args)
    {
        string input = "y";
        Console.WriteLine("Welcome to the Movie List Application!");
        Console.WriteLine("There are 10 movies in this list. ");
        do
        {
            Console.WriteLine("What catagory are you interested in? ");
            input = Console.ReadLine();
            //movie stuff
            
            Console.WriteLine("Continue? (y/n)");
            input = Console.ReadLine().ToLower();

        } while (input == "y");
    }
}