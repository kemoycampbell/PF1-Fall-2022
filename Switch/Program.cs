const int ROCK = 1;
const int PAPER = 2;
const int SCISSOR = 3;

/*Console.Write("Pick a number between 1-3:");
bool converted = int.TryParse(Console.ReadLine(), out int choice);
//if(converted) -> same thing
if(converted==true){
    switch(choice)
    {
        case ROCK:
            Console.WriteLine("You picked Rock");
            break;
        case PAPER:
            Console.WriteLine("You picked paper");
            break;
        case SCISSOR:
            Console.WriteLine("It will cut :-)");
            break;
        default:
            Console.WriteLine("Invalid choice! Pick a choice between 1-3... Is that so hard???");
            break;
    }
} else {
    Console.WriteLine("Unable to convert the input to a number");
} */

//Using string approach
/*Console.Write("Pick a number between 1-3 or type out your choice(rock, paper,scissor):");
switch(Console.ReadLine())
{
    case "1":
    case "rock":
    case "Rock":
    case "ROCK":
        Console.WriteLine("You picked Rock");
        break;
    case "2":
    case "paper":
    case "Paper":
    case "PAPER":
        Console.WriteLine("You picked paper");
        break;
    case "3":
        Console.WriteLine("It will cut :-)");
        break;
    default:
        Console.WriteLine("Invalid choice! Pick a choice between 1-3... Is that so hard???");
        break;
} */

//using when to check ranges
Console.Write("Pick a number between 1-3:");
bool converted = int.TryParse(Console.ReadLine(), out int choice);
//if(converted) -> same thing
if(converted==true){
    switch(choice)
    {
        case int x when x < ROCK || x > SCISSOR:
            Console.WriteLine("Invalid choice");
            break;
        case int x when x == ROCK:
            Console.WriteLine("You picked Rock");
            break;
        case int x when x == PAPER:
            Console.WriteLine("You picked paper");
            break;
        case int x  when x == SCISSOR:
            Console.WriteLine("It will cut :-)");
            break;
    }
} else {
    Console.WriteLine("Unable to convert the input to a number");
} 




