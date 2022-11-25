// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance (int a1, int b1, int c1, int a2, int b2, int c2)
{
double distance = Math.Sqrt((a1-a2)*(a1-a2) + (b1-b2)*(b1-b2) + (c1-c2)*(c1-c2));
double di = Math.Round (distance, 2, MidpointRounding.ToZero);
return di;
}

Console.WriteLine("Введите координаты точки 1");
Console.Write("X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2");
Console.Write("X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z:");
int z2 = Convert.ToInt32(Console.ReadLine());

double length = Distance (x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками -> {length}");
