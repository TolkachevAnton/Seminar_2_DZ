// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
double Dist(int x0, int y0, int z0, int x1, int y1, int z1)
{
double dist = Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2)+ Math.Pow(z1 - z0, 2));
return dist;
}
Console.Write("Введите X0:");
int Ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y0:");
int Ay = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z0:");
int Az = int.Parse(Console.ReadLine()!);

Console.Write("Введите X1:");
int Bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y1:");
int By = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z1:");
int Bz = int.Parse(Console.ReadLine()!);
Console.Write($"Расстояние = {Dist(Ax, Ay, Az, Bx, By, Bz):f2}");

