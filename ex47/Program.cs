// Задача 47: Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int m = 3, n = 4;
double[,] mass = new double[m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = (double) new Random().Next(-10,10) + new Random().NextDouble();
        Console.Write(Math.Round(mass[i,j],2) + " ");

    }
    Console.WriteLine();
}
Console.WriteLine();
