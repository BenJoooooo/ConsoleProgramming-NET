// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Write("Enter your first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// If statements ( ==, <, >, >=, <=, !=)
if(num1 <= num2)
{
    Console.WriteLine("Num2 is greater than num1");
} 
else if(num1 >= num2) 
{
    Console.WriteLine("Num1 is greater than num2");
}
else if (num2 == num1)
{
    Console.WriteLine("Num1 and num2 are equals");
}
else
{
    Console.WriteLine("Error found");
}

// Switch statements
Console.WriteLine("Enter a grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch(grade)
{
    case int i when i >= 0 && i <= 59:
        Console.WriteLine("Grade is Failed");
        break;
    case int i when i >= 60 && i <= 100:
        Console.WriteLine("Grade is Passed");
        break;
    case 101:
        Console.WriteLine("Single case example");
        break;
    default:
        Console.WriteLine("Error found");
        break;
}

// Ternary Operator
var message = num1 > num2 ? "Num1 is larger than num2" : "Num2 is larger than num1";
Console.WriteLine(message);


