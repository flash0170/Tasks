// Задача №11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число {number}");
Console.WriteLine("Удаляем вторую цифру этого числа");


int secondNumber = number / 100 %10;
int ferstNumber = number %10;
Console.Write($"Результат: {secondNumber}{ferstNumber}");