using System.Collections.Generic;

// Dictionary<string, string> carInfos = new Dictionary<string, string>();
// carInfos.Add("12546PJKD", "Brandon");
// carInfos.Add("djkdfkl99", "Kemoy");

// Console.WriteLine(carInfos["djkdfkl99"]);

// //show all elements
// foreach(KeyValuePair<string, string> car in carInfos)
// {
//     Console.WriteLine($"The key is {car.Key} and the value is {car.Value}");
// }

Dictionary<string, Owner> carInfos = new Dictionary<string, Owner>();

Owner brandon = new Owner("Brandon", new DateTime(2005,1,1), 1234567890,"TA-2031");
carInfos.Add("12546PJKD", brandon);
carInfos.Add("djkdfkl99", new Owner("Kemoy", new DateTime(2007,1,1), 123,"Chili"));


Owner owner = carInfos["djkdfkl99"];
Console.WriteLine(owner);
Console.Write(owner.Address);

//change djkdfkl99 to brandon
carInfos["djkdfkl99"] = brandon;

//using loop to display the info
foreach(KeyValuePair<string, Owner> car in carInfos)
{
    Console.WriteLine($"The key is {car.Key} and the value is {car.Value}");
}

Console.Write("\nWhat is the license you want to search?");
string license = Console.ReadLine();

if(carInfos.ContainsKey(license)) {
    Console.WriteLine("Match found");
} else {
    Console.WriteLine("No match found");
}

Console.Write("\nWhat is the license you want to remove?");
license = Console.ReadLine();

if(carInfos.ContainsKey(license))
{
    carInfos.Remove(license);
    Console.WriteLine($"{license} successfully removed");
} else {
    Console.WriteLine("Unable to remove due to no match found");
}

Console.WriteLine($"size:{carInfos.Count}");

while(true)
{
    Console.Write("Enter the license whose date you want to see:");
    license = Console.ReadLine();

    if(carInfos.TryGetValue(license, out owner))
        Console.WriteLine(owner);
    else
        Console.WriteLine($"The key {license} doesnt exist");
}



