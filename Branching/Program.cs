
/**
This is a program that was done in class as a part of
the demo on how to use if statements
*/

Console.WriteLine("=============");
Console.WriteLine("Dress Assistant");
Console.WriteLine("=============");

//Prompt the user for the temperature
Console.Write("What is the temperature today:");
//get the temperature from the user
int temp = int.Parse(Console.ReadLine());

//set up constants to use for comparing
const int SUMMER = 70;
const int WINTER = 47;

//making decisions based on the conditions
if(temp >=SUMMER){
    Console.WriteLine("Wear a short sleeve shirt");
} else if(temp >WINTER && temp<=SUMMER) {
   Console.WriteLine("Probably just a fall sweater");
} else {
    Console.WriteLine("You definitely need a coat!");
}