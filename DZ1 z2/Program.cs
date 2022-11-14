// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа и мы найдем Максимальное");
int max = 0;

Console.WriteLine("Введите первое число");
string str1 = Console.ReadLine();
int num1 = int.Parse(str1);

Console.WriteLine("Введите второе число");
string str2 = Console.ReadLine();
int num2 = int.Parse(str2);

Console.WriteLine("Введите третье число");
string str3 = Console.ReadLine();
int num3 = int.Parse(str3);

if(num1 > max)
{
    max = num1;
}
if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}
Console.WriteLine(max);