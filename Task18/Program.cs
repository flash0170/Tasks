// Задача №18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FindQuarter(int Q)
{

    if (Q == 1)
    {
        Console.WriteLine("X > 0, Y > 0");
    }
    else if (Q == 2)
    {
        Console.WriteLine("X < 0, Y > 0");
    }
    else if (Q == 3)
    {
        Console.WriteLine("X < 0, Y < 0");
    }
    else if (Q == 4)
    {
        Console.WriteLine("X > 0, Y < 0");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}

int Q = Prompt("Введите номер четверти: ");
FindQuarter(Q);