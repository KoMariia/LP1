// // Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool IsExistsTriangle (int ab, int ac, int bc)
{
if (ab < bc + ac && ac < bc + ab && bc < ab + ac) return true;
return false;
}

Console.WriteLine("Введите длину первой стороны треугольника:");
int SideAb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны треугольника:");
int SideBc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны треугольника:");
int SideAc = Convert.ToInt32(Console.ReadLine());

bool existsTriangle = IsExistsTriangle (SideAb, SideBc, SideAc);

Console.WriteLine(existsTriangle == true ? "Треугольник может существовать" : "Такой треугольник не может существовать");