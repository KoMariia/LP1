// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите положительное целое число");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 2) 
{
Console.WriteLine("Число должно быть не меньше 2");
return;
}
int[] fibArray = FibonacciArray(size);
PrintArray(fibArray);

int[] FibonacciArray(int num)
{
    int[] arr = new int[num];
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr, string sep = " ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
        else Console.Write($"{arr[i]}");
    }
}