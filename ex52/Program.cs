// Задача 52: Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом
//столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого
//столбца: 4,6; 5,6; 3,6; 3.
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
for (int j = 0; j < mass.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        sum = sum + mass[i,j];
           
    }
    Console.WriteLine($"Среднее арифметическое {j} столбца: {Math.Round((sum / mass.GetLength(0)),2)}"); 

}

