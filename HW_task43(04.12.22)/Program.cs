// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double XOfIntersection(double k1, double b1, double k2, double b2)
{
    double coordinateX = (b2 - b1) / (k1 - k2);
    return coordinateX;
}

double YOfIntersection(double x1, double k1, double b1)
{
    double coordinateY = x1 * k1 + b1;
    return coordinateY;
}

Console.WriteLine("Введите коэффициенты k и b для первой линии");
double c1 = Convert.ToInt32(Console.ReadLine());
double d1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициенты k и b для второй линии");
double c2 = Convert.ToInt32(Console.ReadLine());
double d2 = Convert.ToInt32(Console.ReadLine());

if (c1 == c2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = XOfIntersection(c1, d1, c2, d2);
    double y = YOfIntersection(x, c1, d1);
    double xRes = Math.Round(x, 2);
    double yRes = Math.Round(y, 2);
    Console.WriteLine($"Точка пересечения линий имеет координаты x = {xRes} и y = {yRes}");
}