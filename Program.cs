using Company;
using System.Text.RegularExpressions;
Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
List<Employee> employees = new List<Employee>();
List<Salesperson> salespersons = new List<Salesperson>();
List<Manager> managers = new List<Manager>();

Console.WriteLine("WELCOME TO THE COMPANY APP");
bool more;
string name, userDate, userBonus, userStock, userEmp;
DateTime dateOfBirth;
double bonus;
int stock;
Regex nameFormate = new Regex("[a-zA-Z]");
Regex dateFormate = new Regex(@"..........");
Regex userInputFormateLetterS = new Regex("[S]");
Regex userInputFormateLetterM = new Regex("[M]");
Regex userInputFormateLetterN = new Regex("[N]");

do
{
    //USER INPUT NAME
    do
    {
        Console.Write("Enter the name : ");
        name = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(name) || !nameFormate.IsMatch(name))
            Console.Write("Invalid!..  ");

    } while (String.IsNullOrWhiteSpace(name) || !nameFormate.IsMatch(name));

    //USER INPUT DATE OF BIRTH
    Console.Write("Enter the date of birth (DD.MM.YYYY) : ");
    userDate = Console.ReadLine();
    while (!DateTime.TryParse(userDate, out dateOfBirth) || !dateFormate.IsMatch(userDate))
    {
        Console.Write("Invalid! Enter the date of birth (DD.MM.YYYY) : ");
        userDate = Console.ReadLine();
    }
        
    //ADDING USER InPUTS TO THE BASE CLASS "EMPLOYEE"
    employees.Add(new Employee(name, dateOfBirth));

    //OUTPUT ONLY "S", "M", "N" LETTERS
    do
    {
        Console.Write("Are you Salesperson-(S), Manager-(M), None of the Above-(N) : ");
        userEmp = Console.ReadLine().ToUpper();
        if (String.IsNullOrWhiteSpace(userEmp) || !(userInputFormateLetterS.IsMatch(userEmp) || userInputFormateLetterM.IsMatch(userEmp) || userInputFormateLetterN.IsMatch(userEmp)) || userEmp.Length > 1)
            Console.Write("Invalid ! ");
    } while (String.IsNullOrWhiteSpace(userEmp) || !(userInputFormateLetterS.IsMatch(userEmp) || userInputFormateLetterM.IsMatch(userEmp) || userInputFormateLetterN.IsMatch(userEmp)) || userEmp.Length > 1);
     
    //CHECK THE OPTIONS
    if (userEmp.StartsWith("S"))
    {
        Console.Write("Enter the bonus percent % (max 200) : ");
        userBonus = Console.ReadLine();
        while (!Double.TryParse(userBonus, out bonus) || bonus > 200 || bonus < 0)
        {
            Console.Write("Invalid!, Enter the bonus percent % (max 200) : ");
            userBonus = Console.ReadLine();
        }
        // ADDING SALESPERSON CLASS
        salespersons.Add(new Salesperson(name, dateOfBirth, bonus));

    }
    else if(userEmp.StartsWith("M"))
    {
        Console.Write("Enter the stock option (max 1000) : ");
        userStock = Console.ReadLine();
        while (!Int32.TryParse(userStock, out stock) || stock > 1000 || stock < 0)
        {
            Console.Write("Invalid! Enter the stock option (max 1000) : ");
            userStock = Console.ReadLine();
        }
        // ADDING MANAGER CLASS
        managers.Add(new Manager(name, dateOfBirth, stock));
    }
    else
    {
        Console.WriteLine("");
    }

    //ADDING MORE TO THE LIST
    Console.Write("You want to add more (Y/N) : ");
    string choice = Console.ReadLine().ToUpper();
    if(choice.StartsWith("Y"))
        more = true;
    else
        more = false;
} while (more);

Console.WriteLine("");

// DISPLAY OF THE EMPLOYEE LIST
Console.WriteLine("****** EMPLOYEES LIST ******");
if (employees.Count > 0)
{
    foreach (var item in employees)
    {
        Console.WriteLine("{0}", item);
    }
}
else
    Console.WriteLine("No data to display");

Console.WriteLine("");


// DISPLAY OF THE MANAGERS LIST
Console.WriteLine("****** MANANEGERS LIST *****");
if (managers.Count > 0)
{
    foreach (var item in managers)
    {
        Console.WriteLine("{0}", item);
    }
}
else
    Console.WriteLine("No data to display");

Console.WriteLine("");


// DISPLAY OF THE SALES PERSON LIST
Console.WriteLine("**** SALESPERSONS LIST *****");
if (salespersons.Count > 0)
{
    foreach (var item in salespersons)
    {
        Console.WriteLine("{0}", item);
    }
}
else
    Console.WriteLine("No data to display");