// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

void FindNumber(int[,] matrix, int x, int y)
{
if ( x >= 0 && x < matrix.GetLength(0) && y >=0 && y < matrix.GetLength(1))
{Console.Write($"{matrix[x, y]}");}
else
{Console.Write("Такого элемента в массиве нет");}
}

Console.WriteLine("Введите количество строк, столбцов, минимально и максимально возможные числа");
int r = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int min1 = Convert.ToInt32(Console.ReadLine());
int max1 = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(r, c, min1, max1);
PrintMatrix(array2D);

Console.WriteLine("Введите координаты необходимого Вам числа");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

FindNumber(array2D, x1, y1);