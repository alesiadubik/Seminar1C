/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if (m>n)
{(m,n)=(n,m);}
int sum(int m,int n)
{
   if (m == n) return n;
   return m+ sum((m+1),n);
}
sum(m,n);
Console.Write($"{sum(m,n)} ");