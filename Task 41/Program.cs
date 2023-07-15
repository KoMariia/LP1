// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.WriteLine("Сколько чисел Вы хотите ввести?");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = EnteringNumbers(number);
PrintArray(array, ", ");

int positiveNumbers = PositiveNumbers(array);
Console.WriteLine($" -> Положительных чисел: {positiveNumbers}");

int[] EnteringNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr, string sep = " ")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int PositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}