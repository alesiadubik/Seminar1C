Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int temp1 = n/10000;
int temp2 = n%10;
int a = (n/10)%1000;
if (temp1 == temp2)
{
    if (a/100 == a%10)
    {
    Console.WriteLine("число палиндром" +n);
    }
    else
    {
        Console.WriteLine("число не палиндром" +n);
    }
}
else
{
    Console.WriteLine("число не палиндром" +n);
}