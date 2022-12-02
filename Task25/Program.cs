// Цикл на вход два числа А и В, возводит А в натуральную степень В
Console.WriteLine("Bведите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bведите число B");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i=0; i<b; i++)
{
    result = result*a;
}
Console.WriteLine($"Число {a} в степени {b} = {result}");