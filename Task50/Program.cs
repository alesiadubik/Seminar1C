// Задача 50. Напишите программу, 
//которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-20, 20);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количетсво строк массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов массива");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[a, b];
FillArray (array);
PrintArray(array);
void FindArray(int[,] array)
{
int index = 0;
for (int k = 0; k <  array.GetLength(0); k++)
{
    for (int m = 0; m < array.GetLength(1); m++)
    {
        if (array[k, m] == number) 
        {
            Console.WriteLine($"Искомое число {number} находиться на позиции: строка {k} и столбец {m}");
            index++;
        }
    }
}
if(index<= 0) Console.WriteLine($"Искомого числа нет!");
}
FindArray(array);
