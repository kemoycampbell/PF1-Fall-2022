// See https://aka.ms/new-console-template for more information


int[] numbers = new int[4];

//show how the max elements the array can store
Console.WriteLine("Max size: "+ numbers.Length);

//the first element
Console.WriteLine("The value of the first element is: "+ numbers[0]);

//change the value of the first element
numbers[0] = 5;
Console.WriteLine("The value of the first element is: "+ numbers[0]);
numbers[0] = 55;
Console.WriteLine("The value of the first element is: "+ numbers[0]);

//set the last element to 100
numbers[3] = 100;
Console.WriteLine("The value of the last element is: "+ numbers[3]);

Console.WriteLine("The additional of the first and the last is "+ (numbers[0] + numbers[3]));

//access an invalid location
//Console.WriteLine(numbers[4]);


