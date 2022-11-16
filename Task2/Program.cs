//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();


double[] GetCross(double a1, double c1, double a2, double c2)
{
    double[] coord = new double [2];
    coord[0] = Math.Round(((c2 - c1) / (a1 - a2)),2);
    coord[1] = Math.Round((a1 * coord[0] + c1),2);
    return coord;
}

Console.WriteLine("Уравнения вида: y = k * x + b");
Console.WriteLine();
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double[] cross = GetCross(k1, b1, k2, b2);
Console.WriteLine($"Точка перечечения двух прямых: y = {k1} * x + {b1}   и   y = {k2} * x + {b2}");
Console.WriteLine();
Console.WriteLine($"Находится в координатах ({cross[0]}; {cross[1]})");
Console.WriteLine();