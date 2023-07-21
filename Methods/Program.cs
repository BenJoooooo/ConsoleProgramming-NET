// See https://aka.ms/new-console-template for more information

// Prototype - Defines the function (type, name, and parameters)
// Definition - Has the code. It contains the code block
// Function Call - Makes the function
// DRY - Don't Repeat Yourself
// YAGNI - You aren't going to need it (Dont call the code if you dont need it)

// Void Functions - Completes a task and moves along
void printName()
{
    Console.WriteLine("Ben Joshua");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"{num1} + {num2} is  = {num1 + num2} ");
}

// Value returning function - Completes a task, returns a result
int largestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if (largest < num2)
    {
        largest = num2;
    }

    if (largest < num3)
    {
        largest = num3;
    }

    return largest;
}

// function printing name
printName();

Console.WriteLine("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// function addition of two numbers
Addition(number1, number2);
Console.WriteLine("End of void function");

Console.WriteLine("Enter a third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

// function of looking for the largest number, then assigning it to a variable
int result = largestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is: {result}");
