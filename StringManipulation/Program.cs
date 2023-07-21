// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string firstName = "Ben Joshua";
string lastName = "Solanor";
DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName + " " + firstName);
Console.WriteLine($"My full name is {lastName}, {firstName}");
// Console.WriteLine("Hello, World!");
Console.WriteLine("My full name is {0}, {1}", lastName, firstName);

// String Length
int length = firstName.Length;
Console.WriteLine($"Number of characters of firstName: {length}");

// Replace string parts
string newName = firstName.Replace('B', 'K');
Console.WriteLine($"Your new name is: {newName}");

// Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name as appended: {fullName}");

// Split String
string[] splitName = fullName.Split('B');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// Compare Strings
string nullString = null; // null
string emptyString = ""; // empty  OR string.Empty
string whiteSpaceString = " ";

if (string.IsNullOrEmpty(nullString))
{
    Console.Write("String is null");
}

Console.Write(" ");

if(firstName == lastName)
{
    Console.WriteLine("Names are equal");
}

Console.WriteLine(" ");

if(firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

if (string.IsNullOrWhiteSpace(whiteSpaceString))
{
    Console.WriteLine("Names has white space");
}

int stringComparison = string.Compare(firstName, lastName);
if (stringComparison == 0)
{
    Console.WriteLine("String are equal");
} else
{
    Console.WriteLine("String are not equal");
}

// Convert to string

string convertedString = string.Empty;
int number = 232342342;

convertedString = number.ToString(); // Option 1
convertedString = 232342342.ToString(); // Option 2
Console.WriteLine(convertedString);

