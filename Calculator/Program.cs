// See https://aka.ms/new-console-template for more information



Console.WriteLine("type in the first number followed by the enter key");
int firstNumber = Convert.ToInt32 (Console.ReadLine());


Console.WriteLine("type in the second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());


int result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} and {1} give the anser {2}", firstNumber, secondNumber, result);