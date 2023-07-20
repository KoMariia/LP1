// Программу, которая заполнит спирально массив (для любого массива).
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] SpiralFillingMatrixInt(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    int k = 1;

    for (int n = 0; k <= matrix.Length; n++)
    {
        for (int j = 0 + n; j < matrix.GetLength(1) - n && k <= matrix.Length; j++)
        {
            int i = n;
            matrix[i, j] = k;
            k++;
        }
        for (int i = n + 1; i < matrix.GetLength(0) - n - 1 && k <= matrix.Length; i++)
        {
            int j = matrix.GetLength(1) - 1 - n;
            matrix[i, j] = k;
            k++;
        }

        for (int j = matrix.GetLength(1) - 1 - n; j >= n && k <= matrix.Length; j--)
        {
            int i = matrix.GetLength(0) - 1 - n;
            matrix[i, j] = k;
            k++;
        }

        for (int i = matrix.GetLength(0) - 2 - n; i >= n + 1 && k <= matrix.Length; i--)
        {
            int j = n;
            matrix[i, j] = k;
            k++;
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


int[,] array2d = SpiralFillingMatrixInt(8, 5);
PrintMatrix(array2d);
Console.WriteLine();