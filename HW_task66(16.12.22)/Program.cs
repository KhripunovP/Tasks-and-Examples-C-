// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num1 + SumNumbers (num1 + 1, num2);
}

Console.WriteLine("Введите натуральные числа M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (m <= n)
{
int result = SumNumbers(m, n);
Console.WriteLine($"{result}");
}
else
Console.WriteLine($"Число M > N");