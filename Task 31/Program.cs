// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = " ")  // задание сепаратора
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] GetSumPositiveNegetiveElem(int[] arr)   // сумма положительных и отрицательных элементов через 1 метод
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }
        return new int[] {sumPositive, sumNegative};
}

int GetSumPositive(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
        return sum;
}


int GetSumNegative(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
        return sum;
}



int[] array = CreateArrayRndInt(12,-9,9);
PrintArray(array, "; ");
Console.WriteLine();
 
int[] sumPositiveNegetiveElem = GetSumPositiveNegetiveElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegetiveElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegetiveElem[1]}");

int getSumPositive = GetSumPositive(array);
int getSumNegative = GetSumNegative(array);
Console.WriteLine($"Сумма положительных элементов = {getSumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {getSumNegative}");