//main method area
// HelloWorld(); //call the HelloWorld method

// //calling the method repeatly in the loop
// for(int i = 0; i< 100; i++)
// {
//     HelloWorld();
// }

// static void HelloWorld()
// {
//     Console.WriteLine("Hello World");
// }

// Console.WriteLine(Add(5,6));
// int sum = Add(5,6);

// Console.WriteLine(sum);
// Console.WriteLine(Add(1000000,2000000));

Console.WriteLine(Divide(10,5));
Console.WriteLine(Divide(10,0));


// Console.ForegroundColor = ConsoleColor.Blue;
// Console.WriteLine("Hello World");
// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("My name is Kemoy");
// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine("This is a pain!!! Tell them!!");

// ShowTextWithColor("Hello World", ConsoleColor.Blue);
// ShowTextWithColor("My name is Kemoy", ConsoleColor.Red);

// CountUp(100, 200);
//CountUp(1,200);

void ShowTextWithColor(string text, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

void CountUp(int start, int stop)
{
    for(int i = 0; i < stop; i++)
        Console.WriteLine(i+1);
    
    return ;
}

/**
This divide two numbers. It takes two numbers and divide them
*/
int Divide(int num1, int num2)
{
    int result = 0;
    if(num2==0)
        Console.WriteLine("cannot divide by 0!");
    
    else {
        result = num1/num2;
    }

    return result;
 


    // return num1/num2;
}


/**
This is a method that add two numbers.
It takes number1, number2 and returns the result of the addition

**/
int Add(int number1, int number2)
{
    // int result = number1 + number2;

    // return result;

    return number1 + number2;
}

