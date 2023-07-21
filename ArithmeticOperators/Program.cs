// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Basic assignment operator
int num = 5;

// Arithmetic operator
int num1 = 20;
int num2 = 10;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

num1 = num1 + 4;
Console.WriteLine($"New Num1: {num1}");
Console.WriteLine($"New Addition: {num1 + num2}");
Console.WriteLine($"New Subtraction: {num1 - num2}");
Console.WriteLine($"New Multiplication: {num1 * num2}");
Console.WriteLine($"New Division: {num1 / num2}");
Console.WriteLine($"New Modulus: {num1 % num2}");

// Compoung assignment operators
num1 += 4;
Console.WriteLine(num1);
num1 -= 4;
Console.WriteLine(num1);
num1 *= 4;
Console.WriteLine(num1);
num1 /= 4;
Console.WriteLine(num1);
num1 %= 4;
Console.WriteLine(num1);
