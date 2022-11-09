public class Film{
    private string category;
    private string name;
    private double duration;

    private string genre;
    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }
    
    public double Duration
    {
        get { return duration; }
        set { duration = value; }
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    public Film()
    {
        Name = "N/A";
        Genre = "N/A";
        Category = "N/A";
        Duration = 0.0;
    }

    public Film(string name, string category, string genre, double duration)
    {
        Name = name;
        Category = category;
        Genre = genre;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"Name:{Name}\nCategory:{Category}\nGenre:{Genre}\nDuration:{Duration}";
    }
    
}