public class Course
{
    private string name;
    public string Name
    {
        get { return name; }
        set { 
            if(!string.IsNullOrEmpty(value))
                name = value; 
            }
    }

    private int number;
    public int Number
    {
        get { return number; }
        set { 
                if(value > 0)
                    number = value; 
            }
    }

    private int section;
    public int Section
    {
        get { return section; }
        set { 
                if(value > 0)
                    section = value; 
            }
    }

    public Course()
    {
        Name = "N/A";
        Section = 0;
        Number = 0;
    }

    public Course(string name, int number, int section)
    {
        Name = name;
        Number = number;
        Section = section;
    }
    

    public override string ToString()
    {
        return Name + "-"+Number + " " + Section;
    }
    
    
}