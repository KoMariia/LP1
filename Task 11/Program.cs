// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72

int number = new Random().Next(100, 1000); 
Console.WriteLine($"Случайное трёхзначное число -> {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"Результат: {result}");
