namespace MovieLab;

public class Movie
{
    // Challenge 3
    // private string _title;
    // private string _catagory;
    // private int _runTime;
    // private int _yearReleased;
    
    //Properties
    //Think of it as a door password. Someone coming up and asking to get but doesn't have the "get" password
    // Will be blocked, same with the set password. This doesn't tell them what they can do in the room itself,
    // just the fact that they can get in ( Bouncer/Guardian)
    public string title{ get;}
    public string catagory{ get;}
    public int runTime { get;}
    public int yearReleased { get;}

    //Constructor
    public Movie(string theTitle, string theCatagory, int theRunTime, int theYearReleased)
    {
        title  = theTitle;
        catagory = theCatagory;
        runTime = theRunTime;
        yearReleased = theYearReleased;

    }
    
    
    // Methods Behaviors

    public override string ToString()
    {
        return $"Title: {title}, Year Released: {yearReleased}, Run Time: {runTime}";
    }

    public void showCat()
    {
        Console.WriteLine(this.catagory);
    }

    // Getters  Method 
    public string GetTitle() => title;
    public string GetCatagory() => catagory;
    public int GetYearRealeased() => yearReleased;
    public int GetRunTime() => runTime;
    
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    

} // End of Movie Class



// findMovies method 
/* .Equals methos
 * Take input in
 * check for incorrect 
 */
// To alphabetical
// To String method 
