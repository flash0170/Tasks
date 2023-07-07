// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Метод рекурсии вычисляет сумму чисел от M до N
 int GetSum(int m, int n)
{
    if (n > m)
        return n + GetSum(m, n - 1);
    return m;
}

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

// Метод выводит результат пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// Вводим данные
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

// Считаем сумму
int sum = GetSum(m,n);

// Выводим результат
PrintData("Сумма элементов от М до N равна: ",sum);