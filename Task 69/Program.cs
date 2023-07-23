// // Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int PowDigit(int numA, int numB)
{
    if (numB == 0) return 1;
    else return numA * PowDigit(numA, numB - 1);
}

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowDigit(numberA, numberB));


int PowDigits(int num1, int num2)
{
if (num2 == 0) return 1;
return num1 * PowDigits(num1, num2 - 1);
}