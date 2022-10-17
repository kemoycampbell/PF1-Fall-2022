StudentRecord osman = new StudentRecord();

osman.firstName = "Osman";
osman.lastName = "Mohamed";
osman.major = "Computer Science";
osman.gpa = 1;


Console.WriteLine(osman.firstName);

Console.WriteLine(osman.lastName);

Console.WriteLine(osman.major);

Console.WriteLine(osman.gpa);
osman.UpdateLastName("Randomness");
Console.WriteLine(osman.IsFailing());

Console.WriteLine("The new last name for osman is:");
Console.WriteLine(osman.lastName);


StudentRecord gabe = new StudentRecord("Gabriel", "Stropes", "ACT", 3.5);

Console.WriteLine(gabe.firstName);

Console.WriteLine(gabe.lastName);

Console.WriteLine(gabe.major);

Console.WriteLine(gabe.gpa);
Console.WriteLine(gabe.IsFailing());


