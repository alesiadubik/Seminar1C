// на вход число и на выход сумму цифр в числе
Console.WriteLine("Bведите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int res = 0;
while (number>0)
{
    res = number%10;
    sum = sum + res;
    number/=10;
}
Console.WriteLine($"Сумма цифр = {sum}");