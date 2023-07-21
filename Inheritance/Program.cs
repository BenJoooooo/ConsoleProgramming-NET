Console.WriteLine("Hello World");

Console.WriteLine("Write the length: ");
var length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write the width: ");
var width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Writhe the height: ");
var height = Convert.ToInt32(Console.ReadLine());

var cube = new Cube(width, length, height);

var triangle1 = new Triangle();
var triangle = new Triangle() { Length = length, Height = height, Hypoteneus = 10 }; // Hypoteneus was not asked in the user input, manual data
var triangle2 = new Triangle(20);
var triangle3 = new Triangle(10, height, length);

var rectangle = new Rectangle() { Length = length, Width = width };

// cube.Length = length;
// cube.Width = width;
// cube.Height = height;

// triangle.Length = length;
// triangle.Height = height;

// rectangle.Length = length;
// rectangle.Width = width;

Console.WriteLine("Cube Area: " + cube.getArea());
Console.WriteLine("Cube Volume: " + cube.getVolume());

Console.WriteLine("Triangle area: " + triangle.getArea());
Console.WriteLine("Rectangle area: " + rectangle.getArea());
