// Задача 69: Напишите программу, которая на вход
// принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
int a = Prompt("Введите основание: ");
int b = Prompt("Введите степень: ");
Console.WriteLine($"Результат -> {Pow(a, b)}");


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

// быстрое возведение в степень
int Pow(int A, int B) 
{
    if(B == 0)
    {
        return 1;
    }
    int temp = Pow(A, B/2);
    int temp2 = (B % 2 == 1)? A: 1;
    return temp * temp * temp2;
}

// медленное возведение в степень
// int Pow(int A, int B)
// {
//     if (B == 0)
//     {
//         return 1;
//     }
//     return Pow(A, B - 1) * A;
// }

