// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.Clear();
// double Dist(int x0, int y0, int z0, int x1, int y1, int z1)
// {
// double dist = Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2)+ Math.Pow(z1 - z0, 2));
// return dist;
// }
// Console.Write("Введите X0:");
// int Ax = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Y0:");
// int Ay = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Z0:");
// int Az = int.Parse(Console.ReadLine()!);

// Console.Write("Введите X1:");
// int Bx = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Y1:");
// int By = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Z1:");
// int Bz = int.Parse(Console.ReadLine()!);
// Console.Write($"Расстояние = {Dist(Ax, Ay, Az, Bx, By, Bz):f2}");



// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да
// // Console.Clear();
// // void Pal(int n)
// // {
// //     //a1.b1.c.b2.a2
// //     int a1 = n / 10000;
// //     int a2 = n % 10;
// //     int b1 = n / 1000 % 10;
// //     int b2 = n % 100 / 10;
// //     if (a1 == a2 && b1 == b2)
// //     {
// //         Console.Write($"{n} -> палиндромом. ");
// //     }
// //     else
// //     {
// //         Console.Write($"{n} -> не палиндромом.");
// //     }
// // }
// // Console.Write("Введите пятизначное число: ");
// // int num = int.Parse(Console.ReadLine()!);
// // if (num > 9999 && num < 100000)
// // {
// //     Console.Write($"{Pal(num)}");
// // }
// // else
// // {
// //     Console.Write("Попробуйте снова!");
// // }
// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num > 9999 && num < 100000)
// {
//     //a1.b1.c.b2.a2
//     int a1 = num / 10000;
//     int a2 = num % 10;
//     int b1 = num / 1000 % 10;
//     int b2 = num % 100 / 10;
//     if (a1 == a2 && b1 == b2)
//     {
//         Console.Write($"{num} -> палиндромом. ");
//     }
//     else
//     {
//         Console.Write($"{num} -> не палиндромом.");
//     }
// }
// else
// {
//     Console.Write("Попробуйте снова!");
// }



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
void Kub(int n)
{
    for (int i=1; i<=n; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}");
        if(i!=n)
        {
            Console.Write(", ");
        }
    }
}
Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine()!);
Kub (N);