// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
string str1 = Console.ReadLine();
int num1 = int.Parse(str1);



Console.WriteLine("Случайное число: " + num1);
int first = num1 % 100; 
int second = first / 10; 

Console.WriteLine("Вторая цифра числа: " + second);
