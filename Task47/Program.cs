﻿// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void FillArray(double[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
        for (int j =0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10,10) + new Random().NextDouble();
}

void PrintDoubleArray(double[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        Console.Write($"{Math.Round(array[i,j],2),3}\t");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количетсво строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [m,n];
FillArray(array);
Console.WriteLine();
PrintDoubleArray(array);
