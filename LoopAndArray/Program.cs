// string[] names = {"Kemoy", "Osman", "Krysstal"};

// Console.WriteLine(names.Length);



int[] numbers = {8,15,-3,0};
Array.Sort(numbers);

for(int i = 0; i< numbers.Length; i++){
    Console.WriteLine(numbers[i]);
}

Array.Reverse(numbers);
for(int i = 0; i< numbers.Length; i++){
    Console.WriteLine(numbers[i]);
}


/*const int MAX = 3;
string[] names = new string[MAX];

//ask for 3 names
for(int index = 0; index < MAX; index++){
    Console.Write("Enter a name");
    names[index] = Console.ReadLine();
}

//show all 3 names
Console.WriteLine("The names are:\n");
for(int index = 0; index < MAX; index++){
    Console.WriteLine(names[index]);
}*/

// int index = 0;
// Console.Write("Enter a name");
// names[index] = Console.ReadLine();
// index++;
// Console.Write("Enter a name");
// names[index] = Console.ReadLine();
// index++;
// Console.Write("Enter a name");
// names[index] = Console.ReadLine();
// index++;


// //reset the index
// index = 0;
// Console.WriteLine("The names are:\n");
// Console.WriteLine(names[index]);
// index++;
// Console.WriteLine(names[index]);
// index++;
// Console.WriteLine(names[index]);

// names[0] = "Loopy";
// names[1] = "Array";
// names[2] = "Magic?";

// Console.WriteLine(names[0]);

// int index = 0;

// Console.WriteLine(names[index]);
// index++;
// Console.WriteLine(names[index]);
// index++;
// Console.WriteLine(names[index]);


