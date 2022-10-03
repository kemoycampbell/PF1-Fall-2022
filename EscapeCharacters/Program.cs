// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,\nWorld!");
Console.WriteLine("Hello,\tWorld!");
Console.WriteLine("Hello,\\World!");
Console.WriteLine("Hello World, The rabbit said to alice,\"Hello Alice\" ");

for(int i = 0; i < 20; i++) {
    Console.Write($"\rPlease wait ...({i})");
    Thread.Sleep(2000);
}

