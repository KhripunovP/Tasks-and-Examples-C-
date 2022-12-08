// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1))
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}

double DifferenceMaxAndMin(double[] array)
{
    int i = 0;
    double min = array[i];
    double max = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    double dif = max - min;
    return dif;
}

Console.WriteLine("введите количество чисел, минимально и максимально возможные числа");
int n = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArrayRndDouble(n, min, max);
PrintArray(arr);
double result = Math.Round(DifferenceMaxAndMin(arr), 1);
Console.WriteLine($"Разница между максимальным и минимальным числами = {result}");