// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers (number);
Console.WriteLine($"Сумма цифр в числе {number} -> {sumNumbers}");


int SumNumbers(int num)
{
    if (num < 0) num *= -1;
    int result = 0;
    while (num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}