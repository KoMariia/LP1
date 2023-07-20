// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {

            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix[i, j] = matrix[i, j] + matrix1[i, k] * matrix2[k, j];
            }

        }
    }
    return matrix;
}



int[,] FirstArray2d = CreateMatrixRndInt(3, 2, 1, 9);
int[,] SecondArray2d = CreateMatrixRndInt(2, 3, 1, 9);

PrintMatrix(FirstArray2d);
Console.WriteLine();
PrintMatrix(SecondArray2d);
Console.WriteLine();

if (FirstArray2d.GetLength(1) != SecondArray2d.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить, число столбцов первой матрицы не равно числу строк второй матрицы");
    return;
}

int[,] matrixMultiplication = MatrixMultiplication(FirstArray2d, SecondArray2d);
Console.WriteLine("Результирующая матрица (произведение):");
PrintMatrix(matrixMultiplication);