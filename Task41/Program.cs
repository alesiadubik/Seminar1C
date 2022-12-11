// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] CreatArray()
{
Console.WriteLine("Введите количество чисел");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа");
int[] nums = new int [n];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
return nums;
}

void CountArray ()
{
int[] nums = CreatArray();    
int count = 0; 
foreach (int i in nums)
    if (i>0)
        count++;
string str = string.Join(", ", nums);
Console.WriteLine(str);
Console.WriteLine($"Количество чисел>0 = {count}");
}
CountArray();

/*Console.WriteLine("Введите количество чисел");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа");
int[] nums = new int [n];
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
    if (nums[i]>0)
    {
        count++;
    }
}
string str = string.Join(", ", nums);
Console.WriteLine(str);
Console.WriteLine($"Количество чисел>0 {count}");*/