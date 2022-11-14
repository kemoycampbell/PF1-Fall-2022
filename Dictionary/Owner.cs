public class Owner
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private DateTime dob;
    public DateTime DOB
    {
        get { return dob; }
        set { dob = value; }
    }

    private string address;
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    
    
    private int ssn;
    public int SSN
    {
        get { return ssn; }
        set { ssn = value; }
    }

    public Owner(string name, DateTime dob, int ssn, string address)
    {
        this.name = name;
        this.dob = dob;
        this.ssn = ssn;
        this.address = address;
    }

    public override string ToString()
    {
        return $"{Name} - {DOB} - {SSN} - {Address}";
    }
}

