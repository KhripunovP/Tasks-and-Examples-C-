// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//456 -> 5
//782 -> 8
//918 -> 1

int SecondDigit (int num)
{
     int secondDigit = (num % 100)/10;
     return secondDigit;
  }

Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int digit2 = SecondDigit (number);

Console.WriteLine($"вторая цифра числа --> {digit2}");
