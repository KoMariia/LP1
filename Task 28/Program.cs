// // Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Введено некорректное число");
}
else
{
int factorial = Factorial(number);
Console.WriteLine($"Факториал числа {number} = {factorial}");
}


int Factorial(int num)  // long для типа данных большего размера
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        fact = fact * i;   // fact *= i;
        }        
    }
    return fact;
}