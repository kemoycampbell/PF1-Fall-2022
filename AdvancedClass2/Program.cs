Student[] students = new Student[30000];
int index = 0;

string[] menus = {
    "1.Add Student",
    "2.Show All Students"
    };





while(true)
{
    ShowMenu();
    switch(Selection())
    {
        case "1":
            AddStudent();
            break;
        case "2":
            ShowInfo();
            break;

    }
}

void ShowInfo()
{
    foreach(Student student in students)
    {
        if(student is not null){
            Console.WriteLine(student);

            Console.WriteLine("Courses:");
            foreach(Course course in student.Courses)
            {
                if(course is not null) {

                    Console.WriteLine(course);
                }
            }
        }
    }
}

void AddStudent()
{
    while(true)
    {
        Console.Write("Enter the name of the student:");
        string name = Console.ReadLine();
        Console.Write("Ente the student year:");
        int year = int.Parse(Console.ReadLine());

        Course[] courses = AddCourses();

        Student student = new Student(name, year, courses);
        students[index] = student;
        index++;

        Console.Write("Do you want to add more student?");
        string choice = Console.ReadLine();

        if(choice.ToUpper().ToCharArray()[0] != 'Y')
            break;
    }
}

Course[] AddCourses()
{
    Course[] courses = new Course[100];
    int position = 0;

    while(true)
    {
        Console.Write("Course name:");
        string name = Console.ReadLine();

        Console.Write("Course number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("section:");
        int section = int.Parse(Console.ReadLine());

        Course course = new Course(name, number, section);
        courses[position] = course;
        position++;

        Console.Write("more courses?");
        string choice = Console.ReadLine();

        if(choice.ToUpper().ToCharArray()[0] != 'Y')
            break;
    }

    return courses;
}


void ShowMenu()
{
    Console.WriteLine("Menu\n=========");
    foreach(string menu in menus)
    {
        Console.WriteLine(menu);
    }
}

string Selection()
{
    Console.Write("Selection:");
    return Console.ReadLine();
}
