// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количетсво строк массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов массива");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[a, b];
FillArray(array);
PrintArray(array);
void AverageArray(int[,] array)
{
double res = 0;
double result = 0;
for (int k = 0; k < array.GetLength(1);k++)
    {
        res =0;
        for (int m = 0; m < array.GetLength(0);m++)
        {
            res+=array[m,k];
            
        }
        Console.Write($"{Math.Round(result=(Convert.ToDouble(res)/a),2)}; ");  
    }
}
Console.WriteLine();
AverageArray(array);
