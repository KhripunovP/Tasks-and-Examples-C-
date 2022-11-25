// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrom (int num)
{
int num1 = num / 10000;
int num2 = num % 10000 / 1000;
int num3 = num % 1000 / 100;
int num4 = num % 100 / 10;
int num5 = num % 10;

return (num1 == num5 && num2 == num4);
}

Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int check = number / 10000;

if (check > 10 || check < 1 )
Console.WriteLine("число не пятизначное");

else{
bool result = Palindrom (number);
Console.WriteLine(result ? "Да, палиндром" : "Нет, не палиндром");
}