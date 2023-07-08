// // Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array1 = new int[8];  // создание массива 0,0,0,0,0,0,0,0
// int[] array2 = new int[8] {3, 6, 4, 8, 9, 7, 3, 5};  // создание массива с заданием значений
// int[] array3 = new int[] {3, 6, 4, 8, 9, 7, 3, 5};
// int[] array4 = {3, 6, 4, 8, 9, 7, 3, 5};

// array1[4] = 564;
// Console.WriteLine(array1[5]);

// for (int i = 0; i < array1.Length; i++)
// {
//     array1[i] = 5646;
//     Console.Write($"{array1[i]} ");
// }

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(2);  // от 0 до 1
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
