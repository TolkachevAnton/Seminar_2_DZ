// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число, чтобы узнать является ли оно четным");

Console.WriteLine("Введите число");
string str = Console.ReadLine();
int num = int.Parse(str);

if(num%2==0)
{
    Console.WriteLine("Ваше число четное");
}
else
{
    Console.WriteLine("Ваше число  не четное");
}
