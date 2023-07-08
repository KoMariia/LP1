// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep = ", ", int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}{sep}");
        else Console.Write($"{num}");
    }
    Console.Write("]");
}

double MaxNum(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] > max) max = arr[i];
    return max;
}

double MinNum(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] < min) min = arr[i];
    return min;
}

double Difference(double max, double min)
{
    double result = max - min;
    return result;
}

double[] array = CreateArrayRndDouble(5, 0, 99);
PrintArrayDouble(array);

double maxNum = MaxNum(array);
double minNum = MinNum(array);
double difference = Difference(maxNum, minNum);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами -> {Math.Round(difference, 1)}");
