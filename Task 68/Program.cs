// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число n");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Оба числа должны быть неотрицательными");
    return;
}

Console.WriteLine(AckermanFunction(numberM, numberN));

int AckermanFunction(int numN, int numM)
{
    if (numN == 0) return numM + 1;
    if (numM == 0) return AckermanFunction(numN - 1, 1);
    return AckermanFunction(numN - 1, AckermanFunction(numN, numM - 1));
}



