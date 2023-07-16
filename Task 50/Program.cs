// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

bool FindNumElemIndex(int[,] matrix, int numRows, int numColums)
{
    if (numRows >= 0 && numRows < matrix.GetLength(0) && numColums >= 0 && numColums < matrix.GetLength(1)) return true;
    return false;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 99);
PrintMatrix(array2d);
Console.WriteLine();

Console.Write("Введите целое положительное число - индекс элемента массива (позиция по строкам): ");
int indexRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное число - индекс элемента массива (позиция по столбцам): ");
int indexColums = Convert.ToInt32(Console.ReadLine());

bool numElemIndexe = FindNumElemIndex(array2d, indexRows, indexColums);

Console.WriteLine(numElemIndexe == true ? $"Значение элемента: {array2d[indexRows, indexColums]}" : "Такого числа в массиве нет");