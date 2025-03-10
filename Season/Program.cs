// See https://aka.ms/new-console-template for more information
using ClassLibrary1;

Console.WriteLine("Input month: ");
int month = int.Parse(Console.ReadLine());

if (month <= 2 || month == 12) 
{
    Console.WriteLine("Winter");
}
else if (month <= 5)
{
    Console.WriteLine("Spring");
}
else if (month <= 8)
{
    Console.WriteLine("Summer");
}
else if (month <= 11)
{
    Console.WriteLine("Fall");
}
else
{
    Console.WriteLine("Error");
}