Console.WriteLine("Введите число");
string number = Console.ReadLine();
if (Convert.ToInt32(number) > 100)
{   
    char[] array = new char[number.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number[i];        
    }
    Console.WriteLine("Третья цифра числа " +array[2]); 
}

else if (Convert.ToInt32(number) < -100)
{   
    char[] array = new char[number.Length];
    for (int i =0; i < array.Length; i++)
    {
        array[i] = number[i];        
    }
    Console.WriteLine("Третья цифра числа " +array[3]); 
}

else
{
   Console.WriteLine("Число не содержит третью цифру"); 
}
