string name = "Sierra";

// char[] letters = name.ToCharArray();

// foreach(char letter in letters)
// {
//     Console.WriteLine(letter);
// }

// Console.WriteLine(name);

// Console.WriteLine(name.ToUpper());
// Console.WriteLine(name.ToLower());

// Console.Write("Enter the password:");
// string password = Console.ReadLine();

// if(password.ToLower() == "sierra")
// {
//     Console.WriteLine("Welcome star!!");
// }

// while(true)
// {
//     Console.Write("Enter a word:");
//     string word = Console.ReadLine();

//     Console.WriteLine("You type: "+ word);

//     Console.Write("Do you want to contine? (Y/N):");
//     string answer = Console.ReadLine();
//     if(answer.ToUpper().ToCharArray()[0] == 'N')
//     {
//         break;
//     }
// }


//searching in a string
string data = "RIT is an awesome university... well, maybe";
// while(true)
// {
//     Console.Write("What do you want to search for?");
//     string target = Console.ReadLine();

//     int matchLocation = data.IndexOf(target);
//     if(matchLocation==-1){
//         Console.WriteLine("No match found");
//     } else {
//         Console.WriteLine("Match at "+ matchLocation);
//     }


// }

string[] words = data.Split(" ");

Console.WriteLine(words.Length);

foreach(string word in words){
    Console.WriteLine(word);
}
