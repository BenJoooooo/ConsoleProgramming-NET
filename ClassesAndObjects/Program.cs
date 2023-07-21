
using ClassesAndObjects;

Person person = new(); // Person person = new Person();

string middleName = string.Empty;

Console.WriteLine("Enter first name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter second name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter middle name: ");
middleName = Console.ReadLine();

Console.WriteLine("Enter age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

// First option 
// person.setSalary();
// double getSalary = person.getSalary();

Console.WriteLine("Enter salary: ");
double salary = Convert.ToDouble(Console.ReadLine());
person.setSalary(salary);
double getSal = person.getSalary();

//Console.WriteLine("First name is: " + person.FirstName);
//Console.WriteLine("Last name is: " + person.LastName);

//Console.WriteLine("Full name is: " + person.getFullName());

/* Method overloading re-creates the same method but with parameters taken from
the program class */
if(string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full name is: " + person.getFullName());
} else
{
    Console.WriteLine("Full name is: " + person.getFullName(middleName));
}

Console.WriteLine("Age is: " + person.Age);
Console.WriteLine("Salary is : " + getSal);

// First option to get the salary
// Console.WriteLine("Salary is: " + getSalary);

//DateUtil dateUtil = new DateUtil();

Console.WriteLine("Age is: " + person.Age);
Console.WriteLine("Year of birth is: " + DateUtil.YearOfBirth(person.Age));