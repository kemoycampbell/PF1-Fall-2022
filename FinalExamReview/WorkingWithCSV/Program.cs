// GameSales sales = new GameSales("Call of duty", "Xbox", "10/10/2022", 1000,2500000);
// Console.WriteLine(sales);
// sales = new GameSales("","", "",-1,-1);
// Console.WriteLine(sales);

const string HEADER = "Ritchie 3.0 EA Games Sales System";
List<GameSales> sales = new List<GameSales>()
// {
//     new GameSales("Call of duty", "Xbox", "10/10/2022", 1000,2500000),
//     new GameSales("Call of duty", "Xbox", "10/10/2022", 1000,2500000),
//     new GameSales("Call of duty", "Xbox", "10/10/2022", 1000,2500000),
//     new GameSales("Call of duty2", "PC", "10/10/2022", 1000,2500000)
// }
;


string[] menuOptions = {
    "Create new sales",
    "Remove a record",
    "Show all sales records",
    "Write records to file",
    "Read in sales from file",
    "Exit"
};
const int JUSTIFY = -20;

//prompt the user to select menu and match each actions
Console.WriteLine(HEADER);
Console.WriteLine(DateTime.Now);
while(true)
{
    switch(Selection())
    {
        case "1":
            CreateNewSales();
            break;
        case "2":
            RemoveRecord();
            break;
        case "3":
            ShowAllSalesRecord();
            break;
        case "4":
            WriteRecordsToFile();
            break;
        case "5":
            ReadFromFile();
            break;
        case "6":
            Console.WriteLine("Thank you for using the system. ADIOS!!!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine($"Invalid selection. Please select 1-{menuOptions.Length}");
            break;
    }
}

string Selection()
{
    Console.WriteLine("Menu\n=======");
    for(int i = 0; i<menuOptions.Length; i++)
    {
        Console.WriteLine($"{i+1}. {menuOptions[i]}");
    }

    Console.Write("Selection:");
    return Console.ReadLine();
}

void CreateNewSales()
{
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Date:");
    string date = Console.ReadLine();
    Console.Write("Platform:");
    string platform = Console.ReadLine();
    Console.Write("Total Copies sold:");
    int total = int.Parse(Console.ReadLine());
    Console.Write("Total Revenue:");
    double revenue = double.Parse(Console.ReadLine());

    GameSales sale = new GameSales(name,platform,date, total,revenue);
    sales.Add(sale);

    Console.WriteLine("New sale record created!");

}

void ShowAllSalesRecord()
{
    Console.WriteLine($"{"Name",JUSTIFY} {"Platform",JUSTIFY} {"Date",JUSTIFY} {"Total Copies Sold",JUSTIFY} {"Total Revenue",JUSTIFY}");
    foreach(GameSales sale in sales)
    {
        Console.WriteLine(sale);
    }

    if(sales.Count == 0){
        Console.WriteLine("The list is empty. No records to display");
    }
    
    Console.WriteLine($"{sales.Count} records displayed");
}

void RemoveRecord()
{
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Platform:");
    string platform = Console.ReadLine();

    bool found = false;
    foreach(GameSales sale in sales)
    {
        if(sale.Name == name && sale.Platform == platform){
            found = true;
            sales.Remove(sale);
            Console.WriteLine("Record successful removed");
            break;
        }
    }
    if(!found){
        Console.WriteLine($"No match found for game name: {name} with platform: {platform}");
    }
}

void WriteRecordsToFile()
{
    string filename = "";
    while(true)
    {
        Console.Write("filename:");
        filename = Console.ReadLine();

        if(!filename.EndsWith(".csv")){
            Console.WriteLine("Invalid file. The filename must end with .csv");
            continue;
        }

        break;
    }

    StreamWriter writer = new StreamWriter(filename);
    //write the header for the csv file
    writer.WriteLine("name,platform,date,totalCopies,revenue");
    foreach(GameSales sale in sales)
    {
        writer.WriteLine($"{sale.Name},{sale.Platform},{sale.Date},{sale.TotalCopiesSold},{sale.TotalRevenue}");
    }

    Console.WriteLine("The records has been written to the file");
    writer.Close();
}

void ReadFromFile()
{
    Console.Write("filename:");
    string filename = Console.ReadLine();

    if(!File.Exists(filename)){
        Console.WriteLine($"Error:Unable to find the file {filename}");
        return;
    }

    StreamReader reader = new StreamReader(filename);
    int line = 0;
    while(!reader.EndOfStream) {
        string content = reader.ReadLine();
        if(line>0 && !string.IsNullOrEmpty(content)){
            string[] fields = content.Split(",");
            string name = fields[0];
            string platform = fields[1];
            string date = fields[2];
            int total = int.Parse(fields[3]);
            double revenue =  double.Parse(fields[4]);

            GameSales sale = new GameSales(name,platform,date,total,revenue);
            sales.Add(sale);
        }
        line++;
    }

    Console.WriteLine("File successfully loaded");
    reader.Close();
}
