// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
int [,] matrix = new int[rows,columns];
int rowsMatrix = 0;
int min = int.MaxValue;
   for (int i = 0; i < rows; i++)
   {
       int sum = 0;
       
      for (int j = 0; j < columns; j++)
      {
         matrix[i,j] = new Random().Next(1,11);

         sum +=matrix [i, j];

         Console.Write(matrix[i,j] + "\t");

         if (sum < min )
         {
            min = sum;
            rowsMatrix = i+1;           
         }
      }   
         System.Console.WriteLine();
   }

System.Console.WriteLine();
Console.WriteLine($"номер строки с наименьшей суммой элементов это - {rowsMatrix}");