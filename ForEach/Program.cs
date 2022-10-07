// int[]  numbers = {1,2,5,6,4,5,9,6,2};

// //for loop
// Console.WriteLine("Using just for loop");
// for(int i = 0; i< numbers.Length; i++)
//     Console.WriteLine(numbers[i]);

// Console.WriteLine("Using for loop with variable name int number");
// for(int i = 0; i< numbers.Length; i++)
// {
//     int number = numbers[i];
//     Console.WriteLine(number);
// }
    
// Console.WriteLine("Using foreach");
// foreach(int number in numbers)
//     Console.WriteLine(number);

// string[] students = {"Sierra", "Gabriel", "Brandon", "David", "Krysstal"};

// Console.Write("Enter the name of the student to search for:");
// string target = Console.ReadLine();

// bool found = false;

// foreach(string student in students){
//     //we find a match
//     // if(target == student)
//     //     Console.WriteLine("Match found!");
//     // else
//     //     Console.WriteLine("No match found");
//     if(target == student)
//     {
//         found = true;
//         Console.WriteLine("Found ya!!!");
//     }
        
// }

// if(found==false) {
//     Console.WriteLine("Match not found");
// }

string[] students = {"Sierra", "Gabriel", "Brandon", "David", "Krysstal"};
double[] gpas = {4.0,5.0,10.0,3.0,3.8};
string[] majors = {"HCC", "ACT", "CS", "CIT", "HCC"};


bool found = false;

Console.WriteLine("===============================");
Console.WriteLine("        GPA REVEALER!!!  ");
Console.WriteLine("===============================");

while(true){
    found = false;
    Console.Write("Enter the name of the student to search for:");
    string target = Console.ReadLine();

    for(int i = 0; i< students.Length; i++){
    string student = students[i];
    double gpa = gpas[i];
    string major = majors[i];

    if(target == student)
    {
        found = true;
        Console.WriteLine($"Name:{student}\nGPA:{gpa}\nMajor:{major}");
        break;
    }
}


    if(found==false) {
        Console.WriteLine("Match not found");
    }
}



