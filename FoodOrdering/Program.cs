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
//LoadFromFileTxt(); //uncomment this if you prefer to load from text file instead of csv
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
            writer.WriteLine(order.FileFormatTxt());
        } else
        {
            if(createCSVHeader)
            {
                writer.WriteLine("name,food,cost");
                createCSVHeader = false;
            }
            writer.WriteLine(order.FileFormatCSV());
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

Order GetAssociatingCustomer(string customerName)
{
    //we find the associating customer record so we will return the order object
    foreach (Order order in orders)
    {
        return order;
    }
    
    //no match is found so we return null
    return null;
}

void LoadFromCSV()
{
    string filename = "order.csv";
    StreamReader reader = new StreamReader(filename);
    bool skipHeader = true;
    

    //we will loop until we reach the end of the file
    while(!reader.EndOfStream){
        string order = reader.ReadLine();
        //we need to skip the first line because first line is the header
        if (skipHeader)
        {

            skipHeader = false;
            continue;
        }

        if (!string.IsNullOrEmpty(order))
        {
            Console.WriteLine(order);
            //get each items separated by comma
            string[] items = order.Split(",");
        
            //the csv is setup as name,food,cost
            string name = items[0];
            string foodName = items[1];
            double cost = double.Parse(items[2]);

            Item food = new Item();
            food.Cost = cost;
            food.Name = foodName;
        
            //do we already have a customer with the order info? if yes then we just add the food item to that customer's record
            Order CustomerOrder = GetAssociatingCustomer(name);
            if (CustomerOrder is not null)
            {
                CustomerOrder.FoodItems.Add(food);
            }
            else
            {
                //the customer doesnt exist so we create a new order to add to the list
                List<Item> foods = new List<Item>();
                foods.Add(food);
                CustomerOrder = new Order(name, foods);
                orders.Add(CustomerOrder);

            }
            

        }

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


