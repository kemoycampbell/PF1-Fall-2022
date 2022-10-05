// Console.WriteLine("Enter the name of the 1st family member:");
// string name = Console.ReadLine();
// Console.WriteLine("Enter the name of the 2nd family member:");
// string name1 = Console.ReadLine();
// Console.WriteLine("Enter the name of the 3rd family member:");
// string name2 = Console.ReadLine();
// Console.WriteLine("Enter the name of the 4th family member:");
// string name3 = Console.ReadLine();
// Console.WriteLine("Enter the name of the 5th family member:");
// string name4 = Console.ReadLine();

/*
int counter = 0;
while(counter < 20){
    Console.WriteLine("The counter value is: " + (counter);
    counter++;
    // counter = counter + 1
    // counter+=1
}
*/
/*
showing 1 based on the output
int counter = 0;
while(counter < 20){
    Console.WriteLine("The counter value is: " + (counter + 1));
    counter++;
    // counter = counter + 1
    // counter+=1
}

*/


/*
Start the counter at 1 based but include the equals sign so 20 get
included in the counter
int counter = 1;
while(counter <= 20){
    Console.WriteLine("The counter value is: " + (counter);
    counter++;
    // counter = counter + 1
    // counter+=1
}
*/


/*int counter = 0;
while(counter < 20){
    Console.WriteLine("The counter value is: " + counter);

    // counter = counter + 1
    // counter+=1
}*/

// int counter = 5;
// while(true)
// {
//     Console.WriteLine("The counter value is: " + counter);
//     counter = counter * 25648411;
// }

// for(int counter = 0; counter < 20; counter++){
//     Console.WriteLine("The counter value is: " + (counter + 1));
// }

/*while(true){
    Console.WriteLine("1. Type something\n2.Exit");
    Console.Write("What would you like to do:");

    string choice = Console.ReadLine();
    if(choice=="1")
    {
            Console.Write("Type your message and press enter:");
            string input = Console.ReadLine();
            Console.WriteLine("You typed: " + input);
    } else
    {
        //break cause the program to quit the loop
        Console.WriteLine("Thank you for trying loopy");
        break;
    }

} */


/*while(true){
    Console.WriteLine("1. Type something\n2.Exit");
    Console.Write("What would you like to do:");

    string choice = Console.ReadLine();
    if(choice=="1")
    {
            Console.Write("Type your message and press enter:");
            string input = Console.ReadLine();
            Console.WriteLine("You typed: " + input);
    }

    else if(choice =="exit"){
        Console.WriteLine("Thank you for testing loopy");
        Console.WriteLine("Exiting program...");
        break;
    }

} */


int counter = 1;

while(counter < 50){
    
    if(counter % 2!=0)
        Console.WriteLine($"{counter} is odd");
    else
        Console.WriteLine($"{counter} is even");
    
    counter++;
}

/*int counter = 1;

while(counter < 50){
    counter++;
    if(counter % 2!=0)
        continue;
    Console.WriteLine($"{counter} is even");
}*/




