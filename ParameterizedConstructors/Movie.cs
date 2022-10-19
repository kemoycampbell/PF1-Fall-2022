public class Movie
{
    // You can create many variables of the same data type separated by a comma
    public string title, genre;

    //  Or you can create them individually
    public int year;
    public int runTime;

    //  This creates an empty constructor
    public Movie()
    {
        title = "N/A";
        genre = "N/A";
    }

    public Movie(string _title, string _genre, int _year, int _runTime)
    {
        title = _title;
        genre = _genre;
        year = _year;
        runTime = _runTime;
    }
}