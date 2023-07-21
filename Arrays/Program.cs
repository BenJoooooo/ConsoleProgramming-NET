// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Declared fixed size arrays
//int[] grades = new int[5];
//grades[0] = 34;
//grades[1] = 45;
//grades[2] = 90;
//grades[3] = 35;
//grades[4] = 23;

int[] grades = new int[] {1,2,3,4,5};
for (int arr = 0; arr < grades.Length; arr++)
{
    Console.WriteLine("Enter a grade: ");
    grades[arr] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The grades are: ");
for (int arr = 0; arr < grades.Length; arr++)
{
    Console.WriteLine(grades[arr]);
}

// Declared variable sized arrays
string[] studentNames = new string[] { "test", "testOne" };

// Add values to variable sized arrays
Console.WriteLine("Enter all names");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write("Enter a name: ");
    studentNames[i] = Console.ReadLine();
}

// Print values in variable sized arrays
Console.WriteLine("The names you have entered: ");
for(int arr = 0; arr < studentNames.Length; arr++)
{
    Console.WriteLine(studentNames[arr]);
}