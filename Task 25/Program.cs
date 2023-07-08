// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB <= 0)
{
    Console.WriteLine("Значение степени введено некорректно");
}
else
{
    int degree = Degree(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} = {degree}");

}
int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        checked
        {
            result = result * num1;    
        }
    }
    return result;
}
