using System.ComponentModel.Design;

string a;
do
{
    Console.Title = "hello";
    Console.WriteLine("hello dear customer please choose one of this");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1.detail");
    Console.ForegroundColor= ConsoleColor.Cyan;
    Console.WriteLine("2.summary");
    Console.ResetColor();
    a = Console.ReadLine();

    if (a == "1")
    {
        Console.Title = "detail";

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("first name : ");
        Console.ResetColor();
        string firstName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("_______________________________________");
        Console.Write("last name : ");
        Console.ResetColor();
        string LastName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("_______________________________________");
        Console.Write("father's name : ");
        Console.ResetColor();
        string FatherName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("_______________________________________");
        Console.Write("date of birth : ");
        int DateOfBirth;
        int Age;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("first name : ");
            Console.ResetColor();
            Console.WriteLine(firstName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________________");
            Console.Write("last name : ");
            Console.ResetColor();
            Console.WriteLine(LastName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________________");
            Console.Write("father's name : ");
            Console.ResetColor();
            Console.WriteLine(FatherName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________________");
            Console.Write("date of birth : ");
            Console.ResetColor();
            DateOfBirth = int.Parse(Console.ReadLine());

            Age = 2023 - DateOfBirth;

            if (Age > 0 && Age < 130)
            {
                Console.Write("your Age is :");
                Console.WriteLine(Age);

            }
            else
            {
                Console.Clear();
                Console.Beep();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("wrong input");
                Console.WriteLine("please press enter key to continue");
                Console.ReadLine();
                Console.ResetColor();


            }
        } while (Age < 0 || Age > 130);

        string cellPhone;
        string PhoneNumber;
        string b;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("first name : ");
            Console.ResetColor();
            Console.WriteLine(firstName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________________");
            Console.Write("last name : ");
            Console.ResetColor();
            Console.WriteLine(LastName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________________");
            Console.Write("father's name : ");
            Console.ResetColor();
            Console.WriteLine(FatherName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________________");
            Console.Write("Age : ");
            Console.ResetColor();
            Console.WriteLine(Age);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________________");
            Console.Write("Phone number : ");
            Console.ResetColor();


            cellPhone = Console.ReadLine();
            PhoneNumber = cellPhone.Substring(0, 12);
            b = PhoneNumber.Substring(0, 2);
            if (b == "09")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("thank you for choosing me as your program ");
                Console.ReadKey();
                break;
            }
            else if (b == "+9")
            {
                string CorrectedPhoneNumber = PhoneNumber.Replace("+98", "0");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("also your phone number is : ");
                Console.ResetColor();
                Console.WriteLine(CorrectedPhoneNumber);
                Console.ReadKey ();
                break;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("wrong input");
                Console.WriteLine("please press any key to continue");
                Console.ResetColor();
                Console.ReadKey();

                continue;

            }
        } while (b != "09" && b != "+9");



        break;
    }

    else if (a == "2")
    {

        Console.Clear();
        Console.Title = "summary";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("first name : ");
        Console.ResetColor();
        string firstName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("_______________________________________");
        Console.Write("last name :");
        Console.ResetColor();
        string LastName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("_______________________________________");
        Console.Write("age : ");
        Console.ResetColor();
        string Age = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("_______________________________________");
        Console.Write("phone number : ");

        string cellPhone;
        string b;
        string PhoneNumber;
        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("firsname : ");
            Console.ResetColor();
            Console.WriteLine(firstName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_______________________________________");
            Console.Write("last name : ");
            Console.ResetColor();
            Console.WriteLine(LastName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_______________________________________");
            Console.Write("Age : ");
            Console.ResetColor();
            Console.WriteLine(Age);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_______________________________________");
            Console.Write("phone number : ");
            Console.ResetColor();

            cellPhone = Console.ReadLine();
            PhoneNumber = cellPhone.Substring(0, 12);
            b = PhoneNumber.Substring(0, 2);
            if (b == "09")
            {
                break;
            }
            else if (b == "+9")
            {
                string CorrectedPhoneNumber = PhoneNumber.Replace("+98", "0");
                Console.Write("also your phone number is : ");
                Console.WriteLine(CorrectedPhoneNumber);
                break;
            }
            else
            {
                Console.Title = "error";
                Console.Clear();
                Console.Beep();
                Console.WriteLine("wrong input");
                Console.WriteLine("please press any key to continue");
                Console.ReadKey();

                continue;

            }
        } while (b != "09" && b != "+9");


    }

    else
    {
        Console.Title = "error";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Beep();
        Console.WriteLine("wrong input");
        Console.WriteLine("please press any key to continue");
        Console.ReadKey();
        continue;
    }

    Console.Clear();
} while (a != "1" & a != "2");