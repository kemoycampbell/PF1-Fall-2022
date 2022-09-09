
// // See https://aka.ms/new-console-template for more information
Console.Title = "Cool Project";
Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Hello, World!");
Console.ResetColor();
Console.ReadKey(); //pause the console.. press any key to continue

string myName = "Kemoy Campbell";

Console.WriteLine("Hello world, I am {0}", myName);
Console.WriteLine("Hello world, I am "+ myName);

Console.WriteLine("\n");

Console.Write("Hello World, here is the magic\n");

Console.Write("I am on a new line??????\n");  

Console.Write("Enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Hello {0} ", name);

Console.Write("How old are you:");
int age = Convert.ToInt32(Console.ReadLine());

const int ADD_ONE = 1;


Console.WriteLine("Whoa, next year you will be {0} ", (age +ADD_ONE));