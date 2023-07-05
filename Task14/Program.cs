// Задача 14: Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.Write("Введите произвольное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 7 == 0 & number % 23 == 0 ) Console.Write($"Число {number} кратно 7 и 23");
 else
 {
     Console.Write($"Число {number} не кратно 7 и 23");
 }