// Задача №3
Console.WriteLine("Введите номер дня нелели:");
int number = int.Parse(Console.ReadLine()!); 

if (number == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (number == 5 )
    {
        Console.WriteLine("Пятница");
    }
    else
        {
            Console.WriteLine("Неопределено");
        }
