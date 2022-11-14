// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32 (Console.ReadLine());
int number2 = Convert.ToInt32 (Console.ReadLine());
int number3 = Convert.ToInt32 (Console.ReadLine());
int max = number1;
if (number2 > max)
max = number2;
if (number3 > max)
max = number3;
Console.WriteLine($"максимальное из трех чисел {max}");
