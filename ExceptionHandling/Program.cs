// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

try
{
    int quotient = number1 / number2;
    Console.WriteLine("The result is: " + quotient.ToString());
} 

catch (DivideByZeroException exc)
{
    Console.WriteLine($"Illegal operation: " + exc.Message);    
}

catch (Exception exc)
{
    throw exc;
}
finally
{
    Console.WriteLine("This is the end of the program");
}