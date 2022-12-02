// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
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

int EvensOfArray(int[] array)
{
    int evens = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            evens = evens + 1;
        }
    }
    return evens;
}

Console.WriteLine("Введите количество трехзначных чисел, минимально и максимально возможные трехзначные числа");
int n = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

if (min < 100 || min > 999 || max < 100 || max > 999)
Console.WriteLine("Диапазон чисел не выполняет условия задачи");

else
   { int[] arr = CreateArrayRndInt(n, min, max);
PrintArray(arr);
int result = EvensOfArray(arr);
   
Console.WriteLine($"Количество четных чисел {result}");
   }