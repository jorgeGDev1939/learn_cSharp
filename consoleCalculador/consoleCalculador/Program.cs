// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number1;
int number2;

Console.WriteLine("input the first number");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input the second number");
number2 = Convert.ToInt32(Console.ReadLine());
int result = (number1 + number2);
Console.WriteLine("the result is: " + result);