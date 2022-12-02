// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] RandomArray()
{
    double[] array = new double[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}
void PrintArray(double[] N)
{
    for (int i = 0; i < N.Length; i++)
    {
        Console.Write($"{N[i]}");
        if (i != N.Length - 1)
        {
            Console.Write(", ");
        }
    }
}
double Diff(double[] AS)
{
    double min = AS[0];
    double max = AS[0];
    for (int i = 0; i < AS.Length; i++)
    {
        if (AS[i] > max)
        {
            max = AS[i];
        }
        if (AS[i] < min)
        {
            min = AS[i];
        }
    }
    double diff = max - min;

    return diff;
}
Console.Clear();
double[] Mass = RandomArray();
PrintArray(Mass);
Console.Write($" ====> {Diff(Mass)}");