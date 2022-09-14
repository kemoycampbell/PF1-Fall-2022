// See https://aka.ms/new-console-template for more information
const double COMMISSION = 10000;
const double COMMISSION_PERCENTAGE = .07;

Console.WriteLine("===========================");
Console.WriteLine("Awesome Commission tool");
Console.WriteLine("===========================");

//ask the user how much they sell this time around
Console.Write("What was your total sales?:");

//get the input from the user
double sales = double.Parse(Console.ReadLine()); //or Convert.ToDouble(Console.ReadLine())

//checking to see if the sales are more than 10k

//APPROACH 1
if(sales > COMMISSION) {
    double earn = sales * COMMISSION_PERCENTAGE;
     Console.WriteLine("Your commission is:$" + earn);

}
//APPROACH 2
/*if(sales > COMMISSION)
    Console.WriteLine("Your commission is: ${0}", (sales * COMMISSION_PERCENTAGE));
*/

