// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator 9000!");

//Area = length x width 
//Perimeter = 4 (area)

Console.WriteLine("Please enter the length of the room in question below:");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the width of the room in question below:");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the height of the room in question below:");
double height = double.Parse(Console.ReadLine());

double area = (length * width);
double perimeter = (4 * area);
double volume = (length * width * height);
double sArea = (2 * (length * height) + 2 * (width * height) + (length * width));


Console.WriteLine($"Thank you for your input.\n\nThe area of the room is {area} sq ft.");
Console.WriteLine($"The perimeter of the room is {perimeter} sq ft.");
Console.WriteLine($"The volume of the room is {volume} sq ft.");
Console.WriteLine($"The surface area of the room is {sArea} sq ft.");

if (perimeter >= 1 && perimeter <= 250)
{
    Console.WriteLine("This is a small room.");
}
else if (perimeter > 250 && perimeter < 650)
{
    Console.WriteLine("This is a medium room.");
}
else 
{
   Console.WriteLine("This is a large room.");
}