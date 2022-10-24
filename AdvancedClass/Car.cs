public class Car
{
    public string Model{set;get;}
    public int RimSize { get; set; }
    public string Name{get;set;}
    public double Cost{get;set;}

    private double gas;
    public double Gas
    {
        get{
            return gas;
        }
    }

    //Default constructor
    public Car()
    {
        Model = "N/A";
        RimSize = 0;
        Name = "N/A";
        Cost = 0.0;
    }

    //Parametrized Constructor
    public Car(string model, string name, int rim, double cost)
    {
        Model = model;
        Name = name;
        RimSize = rim;
        Cost = cost;
    }

    public bool IsTankEmpty()
    {
        return gas<=0;
    }

    public void AddGas(int gas)
    {
        this.gas+= gas;
    }
    
}