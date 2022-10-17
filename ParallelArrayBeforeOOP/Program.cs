string[] names = new string[4];
double[] gpas = new double[4];
string[] majors = new string[4];

names[0] = "Gabriel";
gpas[0] = 3.5;
majors[0] = "Undecided";

names[1] = "Sierra";
gpas[1] = 3.6;
majors[1] = "HCC";

names[2] = "Krysstal";
gpas[2] = 3.6;
majors[2] = "HCC";

names[3] = "Osman";
gpas[3] = 3.1;
majors[3] = "Doesnt know";

//show the student info before update
Console.WriteLine("Original");
ShowStudentInfo(names, majors, gpas);

Console.Write("Enter the student's name to update:");
string target = Console.ReadLine();

for(int i = 0; i< names.Length; i++){
    //we find the matching student so we will update the gpa/major
    if(target.ToLower()==names[i].ToLower()){
        Console.Write("Enter the new major:");
        string major = Console.ReadLine();

        Console.Write("Enter the new GPA:");
        double gpa = double.Parse(Console.ReadLine());

        //update the specific student's major and GPA with what was just entered
        majors[i] = major;
        gpas[i] = gpa;
    }
}

Console.WriteLine("After update Osman's info");
//show the student info after update
ShowStudentInfo(names, majors, gpas);

//sorting the gpa
Array.Sort(gpas);

//showing the info after sorting GPA
Console.WriteLine("After sorting the GPAS");
ShowStudentInfo(names, majors, gpas);

 void ShowStudentInfo(string[] names1, string[] majors1, double[] gpas1)
 {
    Console.WriteLine("calling studentInfoMethod");
    for(int i = 0; i< names1.Length; i++){
        Console.WriteLine($"Name:{names[i]}\nMajor:{majors1[i]}\nGPA:{gpas1[i]}");
        Console.WriteLine();
    }
 }








