// Задача №17: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка.


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindQuarter(int X, int Y)
{

    if (X > 0 && Y > 0)
    {
        Console.WriteLine("I четверть");
    }
    else if (X < 0 && Y > 0)
    {
        Console.WriteLine("II четверть");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("III четверть");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("IV четверть");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}

int x = Prompt("Введите координату точки X: ");
int y = Prompt("Введите координату точки Y: ");
FindQuarter(x, y);
