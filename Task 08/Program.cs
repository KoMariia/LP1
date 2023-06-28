// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
Console.WriteLine("Введено некорректное число, необходимо целое положительное.");  
}
else if (number == 1)
{
Console.WriteLine("Введено число 1, нет чётных чисел.");   
}
else
{
int count = 2;
while (count < number)
{
   Console.Write($"{count} "); 
   count+=2;                    
} 
}