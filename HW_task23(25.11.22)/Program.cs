// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Cube(int number)
{
    int i = 1;
    while (i <= number)
    {
        int a = i * i * i;
        Console.WriteLine($"{i, 4} | {a}");
        i++;
    }
}

Console.WriteLine("введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
Cube(n);
else
Console.WriteLine("Число N не натуральное");