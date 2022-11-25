Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32 (Console.ReadLine());
   
switch (day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
            break;
}

if (day == 6 || day == 7)
    Console.WriteLine("Ура, это выходной!");
else if (day == 1 || day == 2 || day == 3 || day == 4 ||day == 5)
    Console.WriteLine("К сожалению, это будний день");
else
    Console.WriteLine("Неверное число, нет такого дня недели");
    