﻿// Напишите программу, которая на вход принимает два числа
// и проверячет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
    {
     Console.WriteLine("Первое число является квадратом второго");    
    }
else
    {
Console.WriteLine("Первое число не является квадратом второго");     
    }