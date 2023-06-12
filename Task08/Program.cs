// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число N:  ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Четные числа от 1 до N: ");
int count = 1;
while (count <= N)
{
if((count%2 == 0))
Console.Write(count+", ");
count++;   
}
