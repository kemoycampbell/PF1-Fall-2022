public class StudentRecord
{
    private const double FAILING_GPA = 2.0;

    private string firstName;
    private double gpa;

    public string FirstName{
        get{
            return firstName;
        }
        set{
            if(value!="")
                firstName = value;
        }
    }

    public double GPA{
        set{
            if(value > 0)
                gpa = value;
        }

        get{
            return gpa;
        }
    }

    //default constructor
    public StudentRecord(){
        firstName = "No data";
        gpa = 0;
        
    }

    //create a constructor that allows us to pass
    //the values through the parameter
    public StudentRecord(string first, string last, string majorName, double gpaScore)
    {
        FirstName = first;
        // firstName = first;
        // lastName = last;
        // major = majorName;
        // gpa = gpaScore;
    }

    public bool IsFailing()
    {
        return false;
        // if(gpa<=FAILING_GPA)
        //     return true;
        // else
        //     return false;
    }

    public void UpdateLastName(string newLastName)
    {

    }


    /****************************************
        USING GETTER AND SETTER APPROACH

    ******************************************/

    // //creating accessor
    // public string GetFirstName()
    // {
    //     return firstName;
    // }

    // public string GetLastName()
    // {
    //     return lastName;
    // }

    // public string GetMajor()
    // {
    //     return major;
    // }

    // public double GetGPA()
    // {
    //     return gpa;
    // }

    // //Setters
    // public void SetFirstName(string name)
    // {
    //     firstName = name; 
    // }

    // public void setLastName(string name)
    // {
    //     lastName = name;
    // }

    // public void SetMajor(string maj)
    // {
    //     major = maj;
    // }

    // public void setGPA(double gpaScore)
    // {
    //     gpa = gpaScore;
    // }


}

