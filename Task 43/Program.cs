// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
int b1Num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1Num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2Num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2Num = Convert.ToInt32(Console.ReadLine());

if (k1Num == k2Num)
{
    Console.Write("Нет точки пересечения, прямые параллельны.");
    return;
}

double calculationX = CalculationX(b1Num, k1Num, b2Num, k2Num);
double calculationY = CalculationY(b1Num, k1Num, calculationX);
// Console.Write($"Координаты точки пересечения -> ({Math.Round(calculationX, 2)}; {Math.Round(calculationY, 2)})");
Console.Write($"Координаты точки пересечения -> ({calculationX}, {calculationY})");


double CalculationX(int b1, int k1, int b2, int k2)
{
    // double xPoint = (b2 - b1) / (k1 - k2);
    double temp = k1 - k2;
    double xPoint = (b2 - b1) / temp;
    return xPoint;
}

double CalculationY(int b1, int k1, double x)
{
    double yPoint = k1 * x + b1;
    return yPoint;
}
