// Напишите программу.Которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while (count <= number)
{
   Console.Write($"{count} "); // в 1 строку
   count++;                    // или count+=1
} 
