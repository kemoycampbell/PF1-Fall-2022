const string BUSINESS_NAME = "Fun Times Videos";

//  Before we welcome the user, let's create some Movies to have in our inventory
Movie[] moviesLibrary = new Movie[2];

//  Create a Movie object using un-parametarized constructor, and assigning values later
Movie movie1 = new Movie();

movie1.title = "Black Adam";
movie1.genre = "Super Hero / Action";
movie1.year = 2022;
movie1.runTime = 125;

moviesLibrary[0] = movie1;

//  Create a Movie object using the parametarized constructor
Movie movie2 = new Movie("Nikita", "Action", 2000, 180);

moviesLibrary[1] = movie2;

Console.WriteLine($"*** Welcome to {BUSINESS_NAME} ***\n");

Console.WriteLine("Movies avialable for Rent:\n");
for(int i = 0; i < moviesLibrary.Length; i++)
{
    Console.WriteLine($"Title: {moviesLibrary[i].title}\n" +
    $"Genre: {moviesLibrary[i].genre}\n" +
    $"Year: {moviesLibrary[i].year}\n" +
    $"Runtime: {moviesLibrary[i].runTime} minutes");

    Console.WriteLine();
}