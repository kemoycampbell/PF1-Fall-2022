Console.Write("Enter a file name: ");
string filename = Console.ReadLine();

if(!string.IsNullOrEmpty(filename))
    filename += ".txt";

if(File.Exists(filename))
{
    Console.Write("Do you want to overwrite (y/n)? ");
    string overwrite = Console.ReadLine();

    if(!string.IsNullOrEmpty(overwrite) && overwrite.ToLower() == "y")
    {
        WriteToFile(filename);
    }
    else if(!string.IsNullOrEmpty(overwrite) && overwrite.ToLower() == "n")
    {
        Console.WriteLine("Okay, we're not overwriting the file");

        //  Do you want to append data?
        Console.Write("Do you want to append (y/n)? ");
        string append = Console.ReadLine();

        if(!string.IsNullOrEmpty(append) && append.ToLower() == "y")
        {
            AppendToFile(filename);
        }
        else if(!string.IsNullOrEmpty(append) && append.ToLower() == "n")
        {
            Console.WriteLine("Okay, we're not appending to the file");
        }
        else
        {
            Console.WriteLine("We left the file untouched");
        }
    }
    else
    {
        Console.WriteLine("We left the file untouched");
    }
}
else
{
    WriteToFile(filename);
}

void WriteToFile(string filename)
{
    StreamWriter writer = new(filename);

    Console.Write("What is your name? ");
    writer.WriteLine(Console.ReadLine());

    Console.Write("What is your age? ");
    writer.WriteLine(Console.ReadLine());

    writer.Close();

    Console.WriteLine($"You are done writing to {filename}");
}

void AppendToFile(string filename)
{
    StreamWriter writer = File.AppendText(filename);

    Console.WriteLine("Start typing the new information you want to add (enter x to finish): ");

    while(true)
    {
        Console.Write(">>> ");
        string input = Console.ReadLine();

        if(input == "x")
            break;

        writer.WriteLine(input);
        writer.Flush();
    }

    writer.Close();
}