public class Program
{
    
    //main method
    public static void Main(string[] args)
    {
        int sum = Add(5,1);
        Console.WriteLine(sum);
        Console.WriteLine(1);
        Console.WriteLine(true);
        Console.WriteLine("Hello");
        Console.WriteLine();

        sum = Add(3,5) + Add(9,0);

        sum = Add(3,Add(5,9));
        sum = Add(3,5,9);

        Console.WriteLine(Add("5", "6"));

        Console.WriteLine(Program.Add(5,3));
    }

    public static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Add(int number1, int number2, int number3)
    {
        return number1 + number2 + number3;
    }

    public static double Add(double number1, double number2)
    {
        return number1 + number2;
    }

    public static int Add(string num1, string num2)
    {
        return int.Parse(num1) + int.Parse(num2);
    }

}
