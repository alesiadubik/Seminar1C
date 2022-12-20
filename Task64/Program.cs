/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    int num(int n)
    {
        Console.Write($"{(n)} ");
        if (n == 1) return n;
        return num(n - 1);
    }
num (n);
}
else
{
    Console.Write("Необходимо положительное число!");
}