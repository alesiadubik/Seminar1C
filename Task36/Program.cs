// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите длину массива");
int number = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int sum = 0;
int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-100,100);
    Console.Write($"{array[i]} ");
    if (array[i]%2!= 0)
    {sum+=array[i];}
}
Console.WriteLine();
Console.WriteLine($"Сумма нечётных элементов в массиве = {sum}");