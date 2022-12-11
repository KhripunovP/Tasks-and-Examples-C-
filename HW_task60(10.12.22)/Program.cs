// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int numbersForMatrix = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (numbersForMatrix < 100)
                {
                    matrix[i, j, k] = numbersForMatrix;
                    numbersForMatrix++;
                }
                else
                {
                    throw new Exception("Заполнение матрицы неповторяющимися двузначными числами невозможно, элементов больше чем 90");
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                if (k == (matrix.GetLength(2) - 1) && j == (matrix.GetLength(1) - 1))
                {
                    Console.Write($"{matrix[i, j, k]}({i},{j},{k})");
                }
                else
                {
                    Console.Write($"{matrix[i, j, k]}({i},{j},{k}), ");
                }
        }
        Console.WriteLine("]");
    }
}

int[,,] array3D = CreateMatrixRndInt(7, 3, 4);
PrintMatrix(array3D);