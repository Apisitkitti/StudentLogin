using System;
enum Menu
{
    RegisterNewStudent = 1,
    RegisterNewTeacher = 2,
    GetListPersons = 3
}
class Program
{
    static PersonList personList;
    public static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
        InputMenuFromKeyboard();

     
    }
    public static void PrintMenuScreen()
    {
        Console.Clear();
        PrintListMenu();
        
        
    }
    public static void PrintListMenu()
    {
        Console.WriteLine("Welcome to registration new user school application");
        Console.WriteLine("***************************************************");
        Console.WriteLine("1.Registration new Student");
        Console.WriteLine("2.Registration new Teacher");
        Console.WriteLine("3.Get List Persons");
        Console.WriteLine("***************************************************");
    }
    public static void InputMenuFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }

    static void PresentMenu(Menu menu)
    {
        switch(menu)
        {
            case Menu.RegisterNewStudent:
                ShowInputRegistrationNewsStudentScreen();
                break;
            case Menu.RegisterNewTeacher:
                ShowInputRegistrationNewsTeacherScreen();
                break;
            case Menu.GetListPersons:
                ShowPerson();
                break;
            default:
                break;

        }
    }
    public static void ShowInputRegistrationNewsStudentScreen()
    {
        Console.Clear();
        Console.WriteLine("Register New Student");
        Console.WriteLine("********************");
        int totalStudent = TotalNewStudent();

        InputNewStudentFromKeyboard(totalStudent);
    }

    static void PrintHeaderRegisterStudent()
    {
        Console.WriteLine("Register New Student");
        Console.WriteLine("********************");
    }
    static int TotalNewStudent()
    {
        Console.Write("Input Total new Student: ");

        return int.Parse(Console.ReadLine());
    }
    static void InputNewStudentFromKeyboard(int TotalNewStudent)
    {
        for(int i=0; i<TotalNewStudent; i++)
        {
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(InputName(),InputAddress(),InputCitizenID(),InputStudentId());
            Program.personList.AddNewPerson(student);
        }
        BackToMainMenu();
    }
    static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personList = new PersonList();
    }
    static string InputName()
    {
        Console.Write("Name: ");
        return Console.ReadLine();
    }
    static string InputStudentId()
    {
        Console.Write("StudentID: ");
        return Console.ReadLine();
    }
    static string InputAddress()
    {
        Console.Write("Address: ");
        return Console.ReadLine();
    }
    static string InputCitizenID()
    {
        Console.Write("CitizenID: ");
        return Console.ReadLine();
    }
    static string InputEmployeeID()
    {
         Console.Write("EmployeeID: ");
        return Console.ReadLine();
    }
    static void ShowInputRegistrationNewsTeacherScreen()
    {
        Console.Clear();
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("********************");
        int totalNewTeacher = TotalNewTeacher();
        InputNewTeacherFromKeyboard(totalNewTeacher);


    }
    static int TotalNewTeacher()
    {
        Console.Write("Input Total new Teacher: ");

        return int.Parse(Console.ReadLine());
    }
     static void PrintHeaderRegisterTeacher()
    {
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("********************");
    }
    static void InputNewTeacherFromKeyboard(int TotalNewStudent)
    {
        for(int i=0; i<TotalNewStudent; i++)
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            Teacher teacher = new Teacher(InputName(),InputAddress(),InputCitizenID(),InputEmployeeID());
            Program.personList.AddNewPerson(teacher);
        }
        BackToMainMenu();
    }
    static void BackToMainMenu()
    {
        PrintListMenu();
        InputMenuFromKeyboard();
    }
    static void ShowPerson()
    {
        Console.Clear();
        Console.WriteLine("Show Person");
        Console.WriteLine("********************");
        Program.personList.FetchPersonList();

    }

    
}



