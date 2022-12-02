public class GameSales
{
    //create constants to keep program consistent
    private const string DEFAULT_NAME = "Name not provided";
    private const string DEFAULT_PLATFORM = "Platform not provided";
    private const string DEFAULT_DATE = "Date not provided";

    private const int JUSTIFY = -20;

    private string name;
    public string Name
    {
        get { return name; }
        set 
        { 
            if(string.IsNullOrEmpty(value))
                value = DEFAULT_NAME;
            name = value; 
            
        }
    }
    private string date;
    public string Date
    {
        get { return date; }
        set 
        { 
            if(!DateTime.TryParse(value, out DateTime d))
                value = DEFAULT_DATE;
            date = value; 
        }
    }
    private string platform;
    public string Platform
    {
        get { return platform; }
        set 
        { 
            if(string.IsNullOrEmpty(value))
                value = DEFAULT_PLATFORM;
            platform = value; 
        }
    }
    private int totalCopiesSold;
    public int TotalCopiesSold
    {
        get { return totalCopiesSold; }
        set 
        { 
            if(value>=0)
                totalCopiesSold = value; 
        }
    }
    
    private double totalRevenue;
    public double TotalRevenue
    {
        get { return totalRevenue; }
        set 
        { 
            if(value >=0)
                totalRevenue = value; 
        }
    }

    //Default constructor that set up the default variables
    public GameSales()
    {
        name = DEFAULT_NAME;
        date = DEFAULT_DATE;
        platform = DEFAULT_PLATFORM;
        totalCopiesSold = 0;
        totalRevenue = 0;
    }

    public GameSales(string name, string platform, string date, int totalCopiesSold, double totalRevenue)
    {
        Name = name;
        Platform = platform;
        Date = date;
        TotalRevenue = totalRevenue;
        TotalCopiesSold = totalCopiesSold;
    }

    public override string ToString()
    {
        return $"{Name,JUSTIFY} {Platform,JUSTIFY} {Date,JUSTIFY} {TotalCopiesSold,JUSTIFY} {TotalRevenue,JUSTIFY}";
    }


    
}