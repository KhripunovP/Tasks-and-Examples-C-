//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ThirdDigit (int num)
{
    if (num > 0)
    {
     while (num >= 1000)
     {num = num / 10;}
     int thirdDigit = num % 10;
     return thirdDigit;
    }
    else
    {
    while (num <= -1000)
     {num = num / 10;}
     int thirdDigit = -(num % 10);
     return thirdDigit;  
    }
  }

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > -1000 && number < 1000) 
Console.WriteLine("третьей цифры нет");
else
{ 
int number3 = ThirdDigit (number);
Console.WriteLine($"третья цифра числа --> {number3}");
}