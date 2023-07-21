// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

List<string> names = new List<string>();
string name = string.Empty;

// Add values to list
names.Add("Joshua");

Console.WriteLine("Write the names");
while (!name.Equals("-1"))  
{
    Console.WriteLine("Enter a name");
    name = Console.ReadLine();
    if(!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"Name added successfully: {name}");
    } 
}

Console.WriteLine(" ");

// Print values in list
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++ )
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via for each loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}