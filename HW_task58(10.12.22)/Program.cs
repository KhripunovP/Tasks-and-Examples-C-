// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Multiplication(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        throw new Exception("Умножение матриц невозможно");
    }
    else
    {
        int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int x = 0; x < matrix2.GetLength(0); x++)
                {
                    matrix3[i, j] = matrix3[i, j] + matrix1[i, x] * matrix2[x, j];
                }
            }
        }
        return matrix3;
    }
}

int[,] array1 = CreateMatrixRndInt(2, 3, 0, 3);
int[,] array2 = CreateMatrixRndInt(3, 2, 0, 3);

PrintMatrix(array1);
Console.WriteLine();
PrintMatrix(array2);
Console.WriteLine();

int[,] multMatrix = Multiplication(array1, array2);
PrintMatrix(multMatrix);
