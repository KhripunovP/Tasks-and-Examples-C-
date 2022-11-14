// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32 (Console.ReadLine());
int number2 = Convert.ToInt32 (Console.ReadLine());
int max = number1;
int min = number2;
if (number2 > number1)
{max = number2;
min = number1;}
Console.WriteLine($"максимальное из двух чисел - {max}, минимальное - {min}");
