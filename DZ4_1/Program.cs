﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число Б:");
int b = int.Parse(Console.ReadLine());

int multy = a;

for(int i = 1; i < b; i++)
multy = multy*a;

Console.WriteLine($"Число {a} в степени {b} равно {multy}");