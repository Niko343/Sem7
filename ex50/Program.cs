//Задача 50: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
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
Console.WriteLine("Введите строку: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
int b = int.Parse(Console.ReadLine());
if( a > 0 & a <= m & b > 0 & b <= n)
{
 Console.WriteLine($"На этой позиции число {mass[a-1,b-1]}");
}
else Console.WriteLine("Нет числа на такой позиции");

Console.WriteLine(" ");