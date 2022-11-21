public class Order
{
    private string name;

    private double cost;
    public double Cost
    {
    
        get
        {
            cost = 0;
            foreach(Item food in foodItems){
                cost+=food.Cost;
            }

            return cost;
        }
        
        
    }

    private List<Item> foodItems;
    public List<Item> FoodItems
    {
        get { return foodItems; }
        set { foodItems = value; }
    }
    
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Order(string name, List<Item> items)
    {
        this.name = name;
        this.foodItems = items;
    }

    public override string ToString()
    {
        string info = $"Customer:{Name}\nFoods:";
        foreach(Item food in FoodItems) {
            info+=$"{food.Name} --> {food.Cost}\n";
        }

        info+=$"Total cost:{Cost}";

        return info;
    }

    public string FileFormatTxt()
    {
        string info = $"{name}";
        foreach(Item food in foodItems)
        {
            info+=$" {food.Name} {food.Cost}";
        }

        info+=$" {cost}";

        return info;
    }

    public string FileFormatCSV()
    {
        string info = "";
        foreach(Item food in foodItems)
        {
            info+=$"\n{name},{food.Name},{food.Cost}";
        }
        return info;
    }
    
}