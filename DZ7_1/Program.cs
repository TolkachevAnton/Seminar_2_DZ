// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

double[,] GetMatrix(int rows, int columns, int minNumber, int maxNumber)
{
    double[,] matrix = new double[rows, columns];

    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minNumber, maxNumber) / 10.0;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++) //m
    {
        for (int j = 0; j < mtrx.GetLength(1); j++) //n
        {
            if (j == 0) Console.Write("  ");
            Console.Write($"{mtrx[i, j],4}  ");
        }
        Console.WriteLine();
    }
}

double[,] result = GetMatrix(3, 4, -100, 100);
                           //m  n   min  max
PrintMatrix(result);
