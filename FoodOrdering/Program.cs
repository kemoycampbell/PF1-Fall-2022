List<string> menus = new List<string>{
    "Add a new customer order",
    "Show all customers order",
    "Save to file",
    "Exit"
};

List<Order> orders = new List<Order>();

Dictionary<string, double> foodOptions = new Dictionary<string, double>();
foodOptions.Add("Burger", 25.00);
foodOptions.Add("Drink", 35.00);
foodOptions.Add("Fries", 11.00);

LoadFromCSV();
while(true)
{
    ShowMenu();
    Console.Write("Selection:");
    string selection = Console.ReadLine();
    switch(selection)
    {
        case "1":
            AddNewCustomerOrder();
        break;
        case "2":
            ShowCustomerOrders();
        break;
        case "3":
            SaveToFile();
        break;
        case "4":
        break;
        default:
            Console.WriteLine("Invalid selection. Select 1-4");
            break;

    }
}

void ShowMenu()
{
    Console.WriteLine("Menu:");
    for(int i = 0; i< menus.Count; i++) {
        Console.WriteLine($"{i+1} {menus[i]}");
    }

}

void SaveToFile()
{
    Console.WriteLine("Saving order to the file....");
    Console.Write("Name of file:");
    string filename = Console.ReadLine();

    StreamWriter writer = new StreamWriter(filename, true);
    bool createCSVHeader = true;
    foreach(Order order in orders)
    {
        //.csv is not in the file name so we save as .txt
        if(filename.IndexOf(".csv")==-1) {
            writer.Write(order.FileFormatTxt());
        } else
        {
            if(createCSVHeader)
            {
                writer.Write("name,food,cost");
                createCSVHeader = false;
            }
            writer.Write(order.FileFormatCSV());
        }
        
    }

    writer.Close();
}

void ShowCustomerOrders()
{
    foreach(Order order in orders){
        Console.WriteLine(order);
    }
}

void AddNewCustomerOrder()
{
    Console.Write("Customer's name:");
    string name = Console.ReadLine();
    List<Item> foods = new List<Item>();
    while(true)
    {
        Item food = new Item();
        FoodMenu();
        string selection = Console.ReadLine();
        switch(selection)
        {
            case "1":
                food.Cost = foodOptions["Burger"];
                food.Name = "Burger";
                foods.Add(food);
            break;
            case "2":
                food.Cost = foodOptions["Drink"];
                food.Name = "Drink";
                foods.Add(food);
            break;
            case "3":
                food.Cost = foodOptions["Fries"];
                food.Name = "Fries";
                foods.Add(food);
            break;

            default:
                Console.WriteLine("Invalid selection. Please select between 1-3");
                break;
        }

        Console.Write("Do you want to add another food?");
        if(Console.ReadLine().Substring(0).ToUpper() != "Y"){
            break;
        }
    }

    orders.Add(new Order(name, foods));
}

void FoodMenu()
{
    int index = 1;
    foreach(KeyValuePair<string, double> food in foodOptions)
    {
        Console.WriteLine($"{index}. {food.Key} --> {food.Value}");
        index++;
    }

    Console.Write("Selection:");
}

void LoadFromCSV()
{
        string filename = "order.csv";
    StreamReader reader = new StreamReader(filename);

    while(!reader.EndOfStream){
        string order = reader.ReadLine();
        string[] items = order.Split(",");
        string name = items[0];
        List<Item> foods = new List<Item>();
        Item food = new Item();
        for(int i = 1; i < items.Length-1; i++){
            if(double.TryParse(items[i], out double cost)) {
                food.Cost = cost;
                foods.Add(food);
                food = new Item();
            } else {
                food.Name = items[i];
            }
        }

        orders.Add(new Order(name, foods));


    }

    reader.Close();
    Console.WriteLine("info loaded");
}
void LoadFromFileTxt()
{
    string filename = "order.txt";
    StreamReader reader = new StreamReader(filename);

    while(!reader.EndOfStream){
        string order = reader.ReadLine();
        string[] items = order.Split(" ");
        string name = items[0];
        List<Item> foods = new List<Item>();
        Item food = new Item();
        for(int i = 1; i < items.Length-1; i++){
            if(double.TryParse(items[i], out double cost)) {
                food.Cost = cost;
                foods.Add(food);
                food = new Item();
            } else {
                food.Name = items[i];
            }
        }

        orders.Add(new Order(name, foods));


    }

    reader.Close();
    Console.WriteLine("info loaded");
}


