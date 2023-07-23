// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое натуральное число");
int numder1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int numder2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbersNM(numder1, numder2);
Console.WriteLine();
NaturalNumbersNM2(numder1, numder2);


void NaturalNumbersNM(int num1, int num2) //хвостовая рекурсия
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersNM(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersNM(num1 - 1, num2);
    }
    else
    {
        Console.Write($"{num1} ");
    }
}

void NaturalNumbersNM2(int num1, int num2) //обычная рекурсия
{
    if (num1 < num2)
    {
        NaturalNumbersNM(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num1 > num2)
    {
        NaturalNumbersNM(num1, num2 + 1);
        Console.Write($"{num2} ");
    }
    else
    {
        Console.Write($"{num1} ");
    }
}


