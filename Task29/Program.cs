// задать массив из 8 элементов и вывести на экран
Random rnd = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,100);
    Console.Write($"{array[i]} ");
}
