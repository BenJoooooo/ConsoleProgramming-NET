// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Empty date time
using System.Globalization;

DateTime datee = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(2000, 06, 25, 23,03,23); // yy/mm/dd && hh/mm/ss
Console.WriteLine($"My date of birth: {dateOfBirth}");
Console.WriteLine("My date of birth, date only: " + dateOfBirth.Date);
Console.WriteLine("Day of week: " + dateOfBirth.DayOfWeek);
Console.WriteLine("Day of Year: " + dateOfBirth.DayOfYear);
Console.WriteLine("Time of day: " + dateOfBirth.TimeOfDay);
Console.WriteLine("Tick: " + dateOfBirth.Ticks);
Console.WriteLine("Kind: " + dateOfBirth.Kind);

Console.WriteLine(" ");

// Create a DateTime from current timestamp
DateTime now  = DateTime.Now;
Console.WriteLine("Current date and time now is: " + now); 

// Create a DateTime from a string
DateTime dateFromString = DateTime.Parse("06/25/2000", CultureInfo.InvariantCulture);

//string datePassed = Console.ReadLine(); // User input date to insert database
//DateTime dateFromString = DateTime.Parse(datePassed, CultureInfo.InvariantCulture); // variable parsed to the datetime class

Console.WriteLine("Date time from a string: " + dateFromString);

// Add additional to datetime
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

// Ticks from date time
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date only: " + dateOnlyBirth.ToString());

// Time Only
TimeOnly timeOnlyy = TimeOnly.FromDateTime(now);
Console.WriteLine("Time only: " + timeOnlyy.ToString());
