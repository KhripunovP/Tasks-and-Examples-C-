//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

bool DayOfWeek (int num)
{
    return (num >= 6 && num <= 7); 
  }

Console.WriteLine("введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1 )
Console.WriteLine("такого дня недели не существует");
else{
bool result = DayOfWeek (number);
Console.WriteLine(result ? "Да, выходной" : "Нет, не выходной");
}