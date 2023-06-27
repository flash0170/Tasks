// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadDataStr(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

int Summa(int num)
{
    int res = 0;
    while (num >0)
    {
        res = res + num%10;
        num = num /10;
    }
    return res;
}

int number = ReadDataStr("Введите положительное, целое число: ");

DateTime d2 = DateTime.Now;
int summa = Summa(number);

PrintData("Сумма цифр числа равна: ", summa);