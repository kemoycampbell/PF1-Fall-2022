// See https://aka.ms/new-console-template for more information

//setting up the constants
const double COMMISSION_10K = 10000;
const double COMMISSION_PERCENTAGE_SEVEN = .07;
const double COMMISSION_100K = 100000;
const double COMMISSION_PERCENTAGE_TEN = .1;

Console.WriteLine("===========================");
Console.WriteLine("Awesome Commission tool");
Console.WriteLine("===========================");


//ask the user how much they sell this time around
Console.Write("What was your total sales?:");

int.Parse(Console.ReadLine());

//get the input from the user
double sales;

//we attempt to use try parse to see if we can parse the input into a double.
//the converted value will go into the variable sales while the method try parse will assign
//a boolean result to the variable, success
bool success = double.TryParse(Console.ReadLine(), out sales);

//if we successful converted the value then we can go ahead with our computation
if(success){

    //APPROACH 1
    double earn= 0;
    //we will check if the sale is greater than 10,000 and less than 100,000
    //we add the 7% 
    if(sales >= COMMISSION_10K && sales < COMMISSION_100K) {
        earn = sales * COMMISSION_PERCENTAGE_SEVEN;
        Console.WriteLine($"Your commission is:{earn:C}");

    } 
    //we add the 10% if 100,000 or more sales
    else if(sales >=  COMMISSION_100K) {
        earn = sales * COMMISSION_PERCENTAGE_TEN;
        Console.WriteLine($"Your commission is:{earn:C}");
    } 
    //otherwise if the sale is below 10,000 and 100,000 then he gets no comissions
    else {
        Console.WriteLine("No comission increase");
    }
} 
//the conversion failed so we will notify the user of the error
else {
    Console.WriteLine("Come on bruh");
}


//double.Parse(Console.ReadLine()); //or Convert.ToDouble(Console.ReadLine())

//checking to see if the sales are more than 10k


//APPROACH 2
/*if(sales > COMMISSION)
    Console.WriteLine("Your commission is: ${0}", (sales * COMMISSION_PERCENTAGE));
*/


//string justification example
/*Console.WriteLine("{0,-15:N0} {1,15:C}", "12346", "100");

Console.WriteLine("{0,-15:N0} {1,15:C}", "12346", "100");

Console.WriteLine("{0,-15:N0} {1,15:C}", "12346", "100");

Console.WriteLine("{0,-15:N0} {1,15:C}", "12346", "100");

Console.WriteLine("{0,-15:N0} {1,15:C}", "12346", "100");

Console.WriteLine("{0,-15:N0} {1,15:C}", "12346", "100");

Console.WriteLine("{0,-15:N0} {1,15:C}", "12346", "100");

*/

