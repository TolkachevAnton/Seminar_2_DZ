// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Привет! Введите число а и число b, чтбы мы нашли какое из них меньше, а какое больше");
Console.WriteLine();

Console.WriteLine(" Введите число а");
string str = Console.ReadLine();
int a = int.Parse(str);

Console.WriteLine(" Введите число b");
string str1 = Console.ReadLine();
int b = int.Parse(str1);

if( a > b)
{
    Console.WriteLine(" Max это a, Min это b");
}
else 
{
    Console.WriteLine( " Max это b, Min это a");
}