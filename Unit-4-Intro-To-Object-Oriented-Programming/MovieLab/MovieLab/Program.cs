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
            Console.WriteLine($"Here are the catagories we have: ");
            //Display catagory menu -> Switch Case? ForEach?
            
            Console.WriteLine("What catagory are you interested in? ");
            input = Console.ReadLine().ToLower(); //Might need to change this if doing the number challenge
           
            /*
             * NOT SURE IF THIS IS CHECKING
             */
            try // Not sure if this is the best way to check 
            {
                //Cycle through catagories and check if the input is right
                if (movieList.Any(m => String.Equals(m.catagory, input))) ;

            }
            catch (Exception e)
            {
                Console.WriteLine("We do not have that catagory, sorry.");
                throw;
            }
            /*
             * THIS IS NOT WORKING
             */
            foreach (var m in movieList)
            {
                if (m.catagory == input)
                {
                    m.showMovie();
                }
            }
            Console.WriteLine("Continue? (y/n)");
            input = Console.ReadLine().ToLower();

        } while (input == "y");
    }

    /*
     * Change Movies
     */
    static void AddMovies(List<Movie> movies)
    {
        var m1 = new Movie("Star war", "sciFi", 120, 2011);
        movies.Add(m1);
        
        //2
        var m2 = new Movie("Star war", "sciFi", 120, 2011);
        movies.Add(m2);
        
        //3
        var m3 = new Movie("Star war", "horror", 120, 2011);
        movies.Add(m3);
        
        //4
        var m4 = new Movie("Star war", "drama", 120, 2011);
        movies.Add(m4);
        
        //5
        var m5 = new Movie("Star war", "drama", 120, 2011);
        movies.Add(m5);
        
        //6
        var m6 = new Movie("Star war", "drama", 120, 2011);
        movies.Add(m6);
        
        //7
        var m7 = new Movie("Star war", "animated", 120, 2011);
        movies.Add(m7);
        
        //8
        var m8 = new Movie("Star war", "animated", 120, 2011);
        movies.Add(m8);
        
        //9
        var m9 = new Movie("Star war", "animated", 120, 2011);
        movies.Add(m9);
        
        //10
        var m10 = new Movie("Star war", "animated", 120, 2011);
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