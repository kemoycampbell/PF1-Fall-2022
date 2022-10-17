public class StudentRecord
{
    private const double FAILING_GPA = 2.0;
    public string firstName;
    public string lastName;
    public string major;
    public double gpa;

    //default constructor
    public StudentRecord(){}

    //create a constructor that allows us to pass
    //the values through the parameter
    public StudentRecord(string first, string last, string majorName, double gpaScore)
    {
        firstName = first;
        lastName = last;
        major = majorName;
        gpa = gpaScore;
    }

    public bool IsFailing()
    {
        if(gpa<=FAILING_GPA)
            return true;
        else
            return false;
    }

    public void UpdateLastName(string newLastName)
    {
        lastName = newLastName;
    }
}