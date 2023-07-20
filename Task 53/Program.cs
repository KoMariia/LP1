// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];

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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("|");
    }
}

void SwapFirstLastLine(int[,] matrix)
{
    int lastRow = matrix.GetLength(0) - 1;
    int firstRow = 0;
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[firstRow, j];
            matrix[firstRow, j] = matrix[lastRow, j];
            matrix[lastRow, j] = temp;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 99);
PrintMatrix(array2d);
Console.WriteLine();

SwapFirstLastLine(array2d);
PrintMatrix(array2d);