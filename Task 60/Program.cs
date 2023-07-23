// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя
// индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] CreateMatrixTwoDigitInt(int rows, int columns, int depth, int firstNum = 10)
{
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = firstNum;
                firstNum++;
            }

        }
    }
    return matrix;
}

void PrintMatrixTwoDigit(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],4}  ({i},{j},{k})");
            }

        }
        Console.WriteLine();
    }
}

int[,,] matrixTwoDigitInt = CreateMatrixTwoDigitInt(2, 2, 2);
if (matrixTwoDigitInt.Length > 90)
{
    Console.WriteLine("Слишком большое количество элементов - массив из неповторяющихся двузначных чисел сформировать невозможно");
    return;
}
PrintMatrixTwoDigit(matrixTwoDigitInt);
