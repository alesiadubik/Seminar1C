﻿Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 2) == 0)
{
    Console.WriteLine("Чётное число");
}
else
{
    Console.WriteLine("Нечётное число");
}