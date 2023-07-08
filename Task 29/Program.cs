// Напишите программу, которая задаёт массив из 8 элементов, 
//заполненных псевдослучайными числами, и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите целое положительное число (количество элементов массива)");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);  // от 0 до 99
    }
}

void PrintArray(int[] arr)
{
    Console.Write($" -> [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
        Console.Write($"{arr[arr.Length - 1]}]");
}