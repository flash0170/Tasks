// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите чило N -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Вывод результата -> ");
Console.WriteLine($"{Range(n)}");

string Range (int n)
{
    if(n == 1)
    {
        return "1";
    }
    return Range(n-1) + ", " + n;
}