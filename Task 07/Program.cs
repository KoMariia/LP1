// Напишите программу, которая на вход принимает трехзначное число,
// а на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
{
    number *= -1;
}
if (number>=100 && number<=999)
{
    int LastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа {LastDigit}");
}
else
{
    Console.WriteLine("Введено не трёхзначное число");
}