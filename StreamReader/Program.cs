Console.Write("Enter a file name: ");
string filename = Console.ReadLine();

if(!string.IsNullOrEmpty(filename))
    filename += ".txt";

if(File.Exists(filename))
{
    StreamReader reader = new(filename);

    //  To read only one line we can do this
    // Console.WriteLine(
    //     reader.ReadLine()
    // );

    // Console.WriteLine(
    //     reader.ReadLine()
    // );

    // Console.WriteLine(
    //     reader.ReadLine()
    // );

    // Console.WriteLine(
    //     reader.EndOfStream
    // );

    //  Now let's convert this to a loop
    while(!reader.EndOfStream)
    {
        Console.WriteLine(
            reader.ReadLine()
        );
    }

    reader.Close();
}
else
{
    Console.WriteLine($"File {filename} was not found");
}