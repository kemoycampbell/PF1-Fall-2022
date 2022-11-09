using System.Collections.Generic;

//simple example without class
// List<string> items = new List<string>();

// items.Add("one");
// items.Add("Krysstal");
// items.Add("Brandon");
// items.Add("David");

// foreach(string item in items)
// {
//     Console.WriteLine(item);
// }

// //items.RemoveAt(2);
// items.Remove("Brandon");
// Console.WriteLine("");
// foreach(string item in items)
// {
//     Console.WriteLine(item);
// }

//simple test to make sure our class work
//Film LordOfTheRing1 = new Film("Lord of the Ring 1", "Movie","Fantasy",2900);
//Console.WriteLine(LordOfTheRing1);

//setup the list
List<Film> films = new List<Film>();

while(true)
{
    Console.WriteLine();
    Console.WriteLine("1.Add film");
    Console.WriteLine("2.Remove film");
    Console.WriteLine("3. Show all films");

    string selection = Console.ReadLine();

    switch(selection)
    {
        case "1":
            AddFilm();
            break;
        case "2":
            RemoveFilm();
            break;
        case "3":
            ShowAllFilms();
            break;
    }
}

void AddFilm()
{
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Category:");
    string category = Console.ReadLine();
    Console.Write("Genre:");
    string genre = Console.ReadLine();
    Console.Write("Duration:");
    double duration = double.Parse(Console.ReadLine());

    Film film = new Film(name, category, genre, duration);

    films.Add(film);

    Console.WriteLine("Successfully add the film");
}

void ShowAllFilms()
{
    
    foreach(Film film in films) {
        Console.WriteLine(film);
        
    }
    Console.WriteLine($"{films.Count} records displayed");
}

void RemoveFilm()
{
    Console.Write("Movie Name:");
    string name = Console.ReadLine();

    bool match = false;

    foreach(Film film in films) {
        if(film.Name == name){
            films.Remove(film);
            Console.WriteLine("successful deleted");
            match = true;
            break;
        }
    }

    if(match == false) {
        Console.WriteLine("No match found");
    }
}





