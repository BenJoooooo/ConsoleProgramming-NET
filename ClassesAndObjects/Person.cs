//// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Primitive Datatypes
// int, string, char, bool

// Object Oriented Programming - Creating your own datatypes
// Class = blueprint

// Single Responsibility Principle

// Methods = Verbs; person walk, person talk, person sleep
// Properties = Nouns: person first name, person last name, peron age

class Person
{
    // Properties: in public
    // Capital in properties denotes Public access modifier
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    // Fields: in private
    // underscore and lower case properties denotes private access modifier 
    private double _salary { get; set; }

    // Job is to give the field salary a value
    // First option to set salary from a user input
    // public void setSalary()
    // {
    //     Console.WriteLine("Enter salary: ");
    //     _salary = Convert.ToDouble(Console.ReadLine());
    // }

    // Second option to set salary as a parameter
    public void setSalary(double salary)
    {
        _salary = salary;
    }

    // Job is to retrieve the value of the field salary
    public double getSalary()
    {
        return _salary;
    }

    // First option to getfull name
    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }

    // Second option to getfullname
    // public string getFullName(string fullName, string lastName)
    // {
    //     return fullName + lastName;
    // }

    public string getFullName(string middleName)
    {
        return $"{FirstName} {middleName} {LastName}";
    }
}