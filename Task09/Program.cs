// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();
int number = new Random().Next(10, 100);
int firstValue = number / 10;
int secondValue = number % 10;
Console.WriteLine($"Случайное число {number}");
Console.WriteLine($"Первая цифра {firstValue}");
Console.WriteLine($"Втроая цифра {secondValue}");

if (firstValue > secondValue)
    {
        Console.WriteLine($"Наибольшая цифра {firstValue}");
    }
else if (firstValue == secondValue)
    {
        Console.WriteLine("Цифры числа равны");
    }
    else
        {
            Console.WriteLine($"Наибольшая цифра {secondValue}");
        }