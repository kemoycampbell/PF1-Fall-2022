using Newtonsoft.Json;

string[] menus = {
    "Add new vehicle info",
    "Write to file",
    "Read from file",
    "Show vehicles"
};

List<Vehicle> vehicles = new List<Vehicle>();



while(true)
{
    Console.WriteLine("DMV");
    Console.WriteLine("=====");

    switch(Selection())
    {
        case "1":
            Add();
        break;
        case "2":
            Console.Write("Filename:");
            string filename = Console.ReadLine();
            Console.WriteLine("1. Write to CSV");
            Console.WriteLine("2. Write To JSON");
            Console.Write("Selection:");
            if(Console.ReadLine()=="1"){
                WriteToCsv(filename);
            } else {
                WriteToJSON(filename);
            }
            
        break;
        case "3":
            Console.Write("Filename:");
            filename = Console.ReadLine();
            Console.WriteLine("1. Read From CSV");
            Console.WriteLine("2. Read From JSON");
            Console.Write("Selection:");
            if(Console.ReadLine()=="1"){
                ReadFromCsv(filename);
            } else {
                ReadFromJSON(filename);
            }
        break;
        case "4":
            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                Console.WriteLine();
            }
            break;
        default:
            Console.WriteLine("Invalid!!!!");
            break;
    }

}

void Add()
{
    while(true)
    {
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.Write("License number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("License State:");
        string state = Console.ReadLine();

        vehicles.Add(new Vehicle(name, number, state));

        Console.Write("Do you want to add another vehicle:");
        if(!Console.ReadLine().ToUpper().StartsWith("Y"))
            break;

    }
}

string Selection()
{
    int index = 1;
    foreach(string menu in menus){
        Console.WriteLine($"{index}. {menu}");
        index++;
    }

    Console.Write("Selection:");
    return Console.ReadLine();
}

void ReadFromJSON(string filename)
{
    StreamReader reader = new StreamReader(filename);
    string records = reader.ReadToEnd();
    vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(records);
    reader.Close();

    Console.WriteLine("Successfully loaded from JSON");
}

void WriteToJSON(string filename)
{
    StreamWriter writer = new StreamWriter(filename);
    string record = JsonConvert.SerializeObject(vehicles);
    writer.WriteLine(record);
    writer.Close();
}

void WriteToCsv(string filename)
{
    StreamWriter writer = new StreamWriter(filename);
    writer.WriteLine("owner,plate,state");
    foreach(Vehicle vehicle in vehicles) {
        writer.WriteLine($"{vehicle.Owner},{vehicle.LicensePlateNumber},{vehicle.LicensePlateState}");
    }

    writer.Close();

}

void ReadFromCsv(string filename)
{
    StreamReader reader = new StreamReader(filename);
    bool skipHeader = true;
    while(!reader.EndOfStream)
    {
        string info = reader.ReadLine();

        if(skipHeader){
            skipHeader = false;
        }
        else{
            
            if(!string.IsNullOrEmpty(info)) {
                string[] record = info.Split(",");
                string owner = record[0];
                int plate = int.Parse(record[1]);
                string state = record[2];
                vehicles.Add(new Vehicle(owner, plate, state));
            }

        }

    }

    Console.WriteLine("Successfully loaded the records");
}
