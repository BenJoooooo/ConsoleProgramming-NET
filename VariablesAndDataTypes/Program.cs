// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working;

// Prompt the user for input
Console.WriteLine("Please enter your name: ");
fullName = Console.ReadLine();

Console.WriteLine("Please enter your age: "); 
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your salaray: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you working? ");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Your name is: " + fullName); // Concatenation
Console.WriteLine("Your age is: {0}", age); // Args / Arguments
Console.WriteLine($"Your salary is: {salary}"); // Interpolation
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"Are you working? {working}");