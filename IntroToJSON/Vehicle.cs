public class Vehicle
{
    private string owner;
    private int licensePlateNumber;
    private string licensePlateState;

    public string Owner 
    { 
        get => owner;
        set => owner = value; 
    }

    public string LicensePlateState
    {
        get=> licensePlateState;
        set=> licensePlateState = value;
    }

    public int LicensePlateNumber
    {
        get => licensePlateNumber;
        set=> licensePlateNumber = value;
    }

    public Vehicle(string owner, int licensePlateNumber, string licensePlateState)
    {
        Owner = owner;
        LicensePlateNumber = licensePlateNumber;
        LicensePlateState = licensePlateState;

    }
    public Vehicle()
    {
        Owner = "N/A";
        LicensePlateNumber = 0;
        LicensePlateState = "N/A";
    }

    public override string ToString()
    {
        return $"Owner:{Owner}\nLicense:{LicensePlateNumber}-{LicensePlateState}";
    }


}