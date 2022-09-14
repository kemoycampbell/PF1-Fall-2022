// See https://aka.ms/new-console-template for more information
const double COMMISSION_10K = 10000;
const double COMMISSION_PERCENTAGE_SEVEN = .07;
const double COMMISSION_100K = 100000;
const double COMMISSION_PERCENTAGE_TEN = .1;

Console.WriteLine("===========================");
Console.WriteLine("Awesome Commission tool");
Console.WriteLine("===========================");

//ask the user how much they sell this time around
Console.Write("What was your total sales?:");

//get the input from the user
double sales = double.Parse(Console.ReadLine()); //or Convert.ToDouble(Console.ReadLine())

//checking to see if the sales are more than 10k

//APPROACH 1
 double earn= 0;
if(sales >= COMMISSION_10K && sales < COMMISSION_100K) {
     earn = sales * COMMISSION_PERCENTAGE_SEVEN;
     Console.WriteLine("Your commission is:$" + earn);

} else if(sales >=  COMMISSION_100K) {
    earn = sales * COMMISSION_PERCENTAGE_TEN;
    Console.WriteLine("Your commission is:$" + earn);
} else {
    Console.WriteLine("Sorry brah, no cigar!");
}
//APPROACH 2
/*if(sales > COMMISSION)
    Console.WriteLine("Your commission is: ${0}", (sales * COMMISSION_PERCENTAGE));
*/

