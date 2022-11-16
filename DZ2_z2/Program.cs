// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string str1 = Console.ReadLine();
int num1 = int.Parse(str1);

Console.WriteLine("Случайное число: " + num1);
int first = num1 % 100; 
int second = first / 10; 

Console.WriteLine("Вторая цифра числа: " + second);
