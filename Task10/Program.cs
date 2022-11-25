Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32 (Console.ReadLine());
if (number>99 && number<1000)
{
    int temp1 = number / 10;
    int temp2 = temp1 % 10;
    Console.WriteLine(temp2);
}
else
{
    Console.WriteLine("Это нетрёхзначное число!");
}
