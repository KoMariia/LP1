// Напишите программу, которая на вход принимает его и выдаёт его квадрат.

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// - 2 147 483 648 до 2 147 483 647
// 2 вариант преобразования: int number1 = int.Parse(Console.ReadLine());
int square = number * number;
Console.Write($"Квадрат числа {number} = {square}");
