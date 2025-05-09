namespace SampleOOPApplication;
/*
 * This class will represent a Person
 *
 * Attributes:
 *  -> Name
 *  -> Height
 *  -> Age
 *  -> Gender
 */

public class Person
{
    /*
     *  Instance variables identify attributes unique to an object of a class
     */
    
    private string _name; // C# coding convention for private variable with _
    private double _height;
    private int _age;
    private string _gender;
    
    /*
     * Properties
     */

    public string name { get; set; }
    public string height { get; set; }
    public string age { get; set; }
    public string gender { get; set; }

    /*
     * Constructors
     */

    public Person(string name, double height, int age, string gender)
    {
        _name = name;
        _height = height;
        _age = age;
        _gender = gender;
    }
    
    /*
     * Method overrides for default behaviors we don't want
     *
     * ToString()
     * Equals()
     * GetHashCode()
     */
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}//End of Person class