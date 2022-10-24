/***********************
*   TESTING THE CLASS
************************/

// Car test = new Car(); //default
// ShowCarInfo(test);

// Car test2 = new Car("Lambo", "Avender", 3, 200000);
// ShowCarInfo(test2);


//create a array to hold 1000 car classes object
Car[] cars = new Car[1000];

//A loop that goes on forever until the user exit
bool repeat = true;
while(repeat)
{
    //show all menu
    Console.WriteLine("1. Add a new car\n2.Remove a car\n3. Add Gas\n4.Show cars in inventory\n5. Exit\n");
    Console.Write("Selection:");

    //waiting for user input
    switch(Console.ReadLine())
    {
        //add a new car option
        case "1":

            //ask the user for the info about the car so we can add it to the object
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Model:");
            string model = Console.ReadLine();
            Console.Write("Rim(size):");
            int rim = int.Parse(Console.ReadLine());
            Console.Write("Cost:");
            double cost = double.Parse(Console.ReadLine());

            //create the car object
            Car carObj = new Car(model,name, rim, cost);

            //finding an available location in the list
            for(int i = 0; i < cars.Length; i++)
            {
                if(cars[i] == null)
                {
                    cars[i] = carObj;
                    Console.WriteLine("Car successfully added");
                    break;
                }      
            }

            break;

        //removing a car based on the name and model
        case "2":
            Console.Write("Enter the car name:");
            string carName = Console.ReadLine();
            Console.Write("Enter the car model:");
            string mod = Console.ReadLine();
            bool removed = false;
            for(int i = 0; i< cars.Length; i++)
            {
                Car car = cars[i];
                if(car!=null && car.Name == carName && car.Model == mod)
                {
                   
                    car = null;
                    cars[i] = car;
                    removed = true;
                    Console.WriteLine("The car was successful removed");
                    break;
                }
                
            }

            if(!removed) {
                Console.WriteLine($"No car name {carName} and model {mod} found. Car not removed");
            }
            break;

        //add gas to the car
        case "3":
            Console.Write("What is the name of the car you want to add gas to:");
            string target = Console.ReadLine();
            bool match = false;
            foreach(Car car in cars)
            {
                if(car!=null && car.Name == target){
                    Console.Write("How much gas do you want to add(gallon):");
                    int gal = int.Parse(Console.ReadLine());
                    car.AddGas(gal);
                    match = true;
                    break;
                }
            }

            //if match is false
            if(!match){
                Console.WriteLine($"No car name {target} found. Fuel not added" );
            }
            break;
        
        //show all cars in the inventory
        case "4":
            bool listIsEmpty = true;
            foreach(Car car in cars)
            {
                if(car is not null){
                    ShowCarInfo(car);
                    listIsEmpty = false;
                }
                    
            }

            if(listIsEmpty)
                Console.WriteLine("The inventory list is empty. No cars to show");
                
            break;

        //exit the system
        case "5":
            Console.WriteLine("Thank you for using our system");
            repeat = false;
            break;

        default:
            Console.WriteLine("Invalid selection. Please select 1-4");
            break;
    }
}


//a method to use to show all car data. Easier to use a method especially when repeating the code.
//default and parameterized constructor use the same codes so method helps us with that
void ShowCarInfo(Car car)
{
    
    Console.WriteLine($"name: {car.Name}");
    Console.WriteLine($"Model:{car.Model}");
    Console.WriteLine($"Rim:{car.RimSize}");
    Console.WriteLine($"Cost:{car.Cost:C}");
    Console.WriteLine($"Gas:{car.Gas}");
    Console.WriteLine("\n");
}