﻿// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int b3 = Convert.ToInt32(Console.ReadLine());

double result = Distance(a1, a2, a3, b1, b2, b3);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {resultRound}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int cat1 = x1 - x2;
    int cat2 = y1 - y2;
    int cat3 = z1 - z2;
    double dist = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
    return dist;
}
