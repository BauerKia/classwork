namespace MovieLab;

public class Movie
{
    // Challenge 3
    private string _title;
    private string _catagory;
    private int _runTime;
    private int _yearReleased;
    

    //Constructor
    public Movie(string theTitle, string theCatagory, int theRunTime, int theYearReleased)
    {
        this.title = theTitle;
        this.catagory = theCatagory;
        this.runTime = theRunTime;
        this.yearReleased = theYearReleased;

    }
    
    //Properties
    public string title{ get; set;}
    public string catagory{ get;  set;}
    public int runTime { get;  set;}
    public int yearReleased { get; set;}
    // Methods Behaviors

    public override string ToString()
    {
        return $"Title: {title}, Year Released: {yearReleased}, Run Time: {runTime}";
    }

    public void showMovie()
    {
        Console.WriteLine(this);
    }
    

} // End of Movie Class



// findMovies method 
/* .Equals methos
 * Take input in
 * check for incorrect 
 */
// To alphabetical
// To String method 
