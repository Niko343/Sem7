//Задача 51: Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали (с индексами
//(0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12
int m = 3, n = 4;
double[,] mass = new double[m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = (double) new Random().Next(0,10);
        Console.Write(mass[i,j] + " ");

    }
    Console.WriteLine();
}
Console.WriteLine();
double sum = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
       if(i == j)
       {
        sum = sum + mass[i,j];
       }
    }
}
Console.Write($"Сумма чисел на главной диагонали равна {sum}");
