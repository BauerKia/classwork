namespace MovieLab;

class Program
{ 
    static void Main(string[] args){
        List<Movie> movieList = new List<Movie>();
        //Movies
        AddMovies(movieList);
        
        string input = "y";
        Console.WriteLine("Welcome to the Movie List Application!");
        Console.WriteLine($"There are {movieList.Count} movies in this list. ");
        do
        {
            //https://stackoverflow.com/questions/2537823/distinct-by-property-of-class-with-linq
            /*
             * Taking the MovieList and getting just the catagories by grouping the property
             * then only getting one of them
             * Issue Faced: Had to move this outsdie because I repeating it every single loop of the foreach 
             */
            List<Movie> catagoryList =
                movieList
                    .GroupBy(m => m.GetCatagory())
                    .Select(f => f.First())
                    .ToList();
            Console.WriteLine($"Here are the catagories we have: ");
            //Display catagory menu -> Switch Case? ForEach?
            foreach (var c in catagoryList)
            {
                Console.WriteLine($"{c.GetCatagory()}");
            }
            
            
            Console.WriteLine("What catagory are you interested in? ");
            input = Console.ReadLine().ToLower(); //Might need to change this if doing the number challenge

            /*
             * Good God please T.T
             * Why does try/catch not work?
             * Make another variable to save the movies with the same catagory as the user input in a list from the main movieList
             */
            List<Movie> sameMovies = movieList.Where(m => m.GetCatagory().ToLower() == input).ToList();

            if (sameMovies.Any())
            {
                foreach (var m in sameMovies)
                {
                    Console.WriteLine($"{m}");
                }
            }
            else
            {
                Console.WriteLine($"We do not have {input} movies. Sorry!");
            }




            Console.WriteLine("Continue? (y/n)");
            input = Console.ReadLine().ToLower();

        } while (input == "y");
    }

    /*
     * Change Movies!
     */
    static void AddMovies(List<Movie> movies)
    {
        var m1 = new Movie("Dune", "SciFi", 155, 2021);
        movies.Add(m1);
        
        //2
        var m2 = new Movie("Blade Runner 2049", "SciFi", 164, 2017);
        movies.Add(m2);
        
        //3
        var m3 = new Movie("A Quiet Place", "Horror", 90, 2018);
        movies.Add(m3);
        
        //4
        var m4 = new Movie("Nomadland", "Drama", 108, 2020);
        movies.Add(m4);
        
        //5
        var m5 = new Movie("Parasite", "Drama", 132, 2019);
        movies.Add(m5);
        
        //6
        var m6 = new Movie("The Fault in Our Stars", "Drama", 126, 2014);
        movies.Add(m6);
        
        //7
        var m7 = new Movie("Luca", "Animated", 95, 2021);
        movies.Add(m7);
        
        //8
        var m8 = new Movie("Finding Nemo", "Animated", 100, 2003);
        movies.Add(m8);
        
        //9
        var m9 = new Movie("Lilo & Stich", "Animated", 85, 2002);
        movies.Add(m9);
        
        //10
        var m10 = new Movie("Encanto", "Animated", 102, 2021);
        movies.Add(m10);
        
        //11 and onwards?
        // movies.Add(input) --> Movie input being a parameter? Is this any better than just Add?
        
    }
/*
 * Adjust set up, does this need to be a method?
 */
    // static Movie DisplayMovies(List<Movie> movies, string input)
    // {
    //     ///Something is here, but I think you can use this below to do a for each throguh the list to only save the correct catagoies.
    //     
    // }
}