// Задача 49: Задайте двумерный массив. Найдите элементы, у
//которых оба индекса чётные, и замените эти элементы на их
//квадраты.
//Например, изначально массив
// выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть
//вот так:
//1 4 7 2
//5 81 2 9
//8 4 2 4
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
Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i % 2 == 0 & j % 2 == 0)
        {
            mass[i,j] = Math.Pow(mass[i,j], 2);
            Console.Write(mass[i,j] + " ");
        }
        else
        {
            Console.Write(mass[i,j] + " ");
        }
    }
    Console.WriteLine();
}
