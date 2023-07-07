// Задача 67: Напишите программу, которая
// будет принимать на вход число и
// возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

int number = Prompt("Введите число ->  ");
Console.Write("Сумма цифр -> ");
Console.WriteLine($"{SumDigit(number)}");

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumDigit(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return SumDigit(n / 10) + (n % 10);
}