// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int sum = 0;

// for (int i = 0; i < str.Length; i++)
// {
//     char currentChar = str[i];
//     int positionOfChar = Convert.ToInt32(currentChar);
//     int numberFromChar = int.Parse(currentChar.ToString());
//     Console.Write($"Сивол: {currentChar}, позиция: {positionOfChar}, число: {numberFromChar} \n");
// }

for (int i = 0; i < str.Length; i++)
{
    int currentNumber = int.Parse(str[i].ToString());
    sum += currentNumber; // sum = sum + currentNumber
}
Console.WriteLine(sum);