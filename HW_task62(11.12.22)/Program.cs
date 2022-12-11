// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] SpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int e = 0;
    int elementsOfMatrix = rows * columns;
    int element = 1;
    int maxI = rows - 1;
    int maxJ = columns - 1;

    while (element <= elementsOfMatrix)
    {
        for (int j = e; j <= (maxJ - e); j++)
        {
            matrix[e, j] = element;
            element = element + 1;
        }
        for (int i = e + 1; i <= (maxI - e); i++)
        {
            matrix[i, maxJ - e] = element;
            element = element + 1;
        }
        for (int j = (maxJ - 1 - e); j >= e; j--)
        {
            matrix[maxI - e, j] = element;
            element = element + 1;
        }
        for (int i = (maxI - 1 - e); i >= e + 1; i--)
        {
            matrix[i, e] = element;
            element = element + 1;
        }
        e = e + 1;
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

int[,] array1 = SpiralMatrix(4, 4);
PrintMatrix(array1);