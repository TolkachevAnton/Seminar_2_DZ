// Задача 58: Задайте два двумерных массива (от 0 до 10). 
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

int [,] firstMatrix = new int[4,4];
int [,] secondMatrix = new int [4,4];
int [,] resultMatrix = new int [4,4];

for (int i = 0; i < 4; i++)
{
   Console.WriteLine();
   for (int j = 0; j < 4; j++)
   {
      firstMatrix[i,j] = new Random().Next(1,11);
      
   
      Console.Write(firstMatrix[i,j] + "\t");
      
   }
  
}
System.Console.WriteLine();

for (int i = 0; i < 4; i++)
{
   Console.WriteLine();
   for (int j = 0; j < 4; j++)
   {
      secondMatrix[i,j] = new Random().Next(1,11);

      Console.Write(secondMatrix[i,j] + "\t");
         
   }
  
}
System.Console.WriteLine();

for (int i = 0; i < 4; i++)
{

   Console.WriteLine();
   for (int j = 0; j < 4; j++)
   {
      resultMatrix[i,j] = firstMatrix[i,j]* secondMatrix[i,j];
   
      Console.Write(resultMatrix[i,j] + "\t");
      
   }
  
}
