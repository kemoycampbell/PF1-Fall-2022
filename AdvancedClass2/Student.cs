public class Student
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int year;
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    
    private Course[] courses;
    public Course[] Courses
    {
        get { return courses; }
        set { courses = value; }
    }

    public Student()
    {
        Name = "N/A";
        Year = 0;
        Courses = new Course[100];
    }

    public Student(string name, int year, Course[] courses)
    {
        Name = name;
        Year = year;
        Courses = courses;
    }

    public override string ToString()
    {
        return Name + " " + Year;
    }
    
    
    
}