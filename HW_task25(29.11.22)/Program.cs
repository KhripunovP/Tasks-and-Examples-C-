// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

int Exponentiation(int num1, int num2)
{
    int num = 1;
    for (int i = 1; i <= num2; i++)
    {
        num = num * num1;
    }
    return num;
}

Console.WriteLine("введите натуральное число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите натуральное число B");
int b = Convert.ToInt32(Console.ReadLine());

if (a > 0 && b > 0)
{
    int result = Exponentiation(a, b);
    Console.WriteLine($"A в степени B равно {result}");
}
else
    Console.WriteLine("Вы плохо учили в школе, что такое натуральные числа");

