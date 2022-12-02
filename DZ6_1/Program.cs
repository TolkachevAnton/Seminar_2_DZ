// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void IntList(int n)
{
List<int> Ints = new List<int>(); // Список целых чисел
int k = 0;
for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        Ints.Add(int.Parse(Console.ReadLine()));
        if (Ints[i] > 0) k++;
    }

Console.WriteLine();
Console.WriteLine($"Вы ввели список {n} целых чисел: " + String.Join(", ", Ints) + ".");
Console.WriteLine();
Console.WriteLine($"Из них положительных чисел: {k}.");
Console.WriteLine();
}

Console.Write("Введите количество целых чисел, которые будете вводить: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine();

IntList(M);