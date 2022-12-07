// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Max (int[] array)
{
  int max = array[0];
  for (int index = 0; index < array.Length; index++)
  if (array[index]> max) max = array[index];
  return max;
}

int Min (int[] array)
{
  int min = array[0];
  for (int j = 0; j < array.Length; j++)
  if (array[j]< min) min = array[j];
  return min;
}

Console.WriteLine("Введите длину массива");
int number = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-100, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int max=Max(array);
int min=Min(array);
int different = max-min;
Console.WriteLine($"Разница между max {max} и min {min} = {different}");