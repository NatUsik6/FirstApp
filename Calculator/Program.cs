// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, I'm Calculator! Enter first number, operation and second number");
int numberOne = int.Parse(Console.ReadLine());
string operation = Console.ReadLine();
int numberTwo = int.Parse(Console.ReadLine());

switch (operation)
{
    case "+":
        Console.WriteLine(numberOne + numberTwo);
        break;
    case "-":
        Console.WriteLine(numberOne - numberTwo);
        break;
    case "*":
        Console.WriteLine(numberOne * numberTwo);
        break;
    case "/":
        Console.WriteLine(numberOne / numberTwo);
        break;
}