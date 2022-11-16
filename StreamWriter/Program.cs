﻿Console.Write("Enter a file name: ");
string filename = Console.ReadLine();

if(!string.IsNullOrEmpty(filename))
    filename += ".txt";

if(File.Exists(filename))
{
    Console.WriteLine("Sorry, that file already exists");

    Console.Write("Do you want to overwrite (y/n)? ");
    string overwrite = Console.ReadLine();

    if(!string.IsNullOrEmpty(overwrite) && overwrite.ToLower() == "y")
    {
        WriteToFile(filename);
    }
    else if(!string.IsNullOrEmpty(overwrite) && overwrite.ToLower() == "n")
    {
        Console.WriteLine("Okay, we're not overwriting the file");
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