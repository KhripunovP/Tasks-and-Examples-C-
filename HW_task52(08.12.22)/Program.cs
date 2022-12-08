// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

void Average(int[,] matrix)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        double average = 0;
        int rows = matrix.GetLength(0);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = average + matrix[i, j];
        }
        average = average / rows;
        double aver = Math.Round(average, 1);
        Console.Write($"{aver}, ");
    }

    for (int j = matrix.GetLength(1) - 1; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        int rows = matrix.GetLength(0);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = average + matrix[i, j];
        }
        average = average / rows;
        double aver = Math.Round(average, 1);
        Console.Write($"{aver}.");
    }
}

Console.WriteLine("Введите количество строк, столбцов, минимально и максимально возможные числа");
int r = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(r, c, min, max);
PrintMatrix(array2D);

Average(array2D);