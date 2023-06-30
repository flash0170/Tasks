// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет


// Метод ввода данных с консоли
int ReadData(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}


// Метод генерации массива 
int[,] GenArray(int row , int column)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, 9);
            j++;
        }
        i++;
    }
    return arr;
}


// Метод вывода массива
void PrintArray(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n=== ДВУМЕРНЫЙ МАССИВ ===");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


// Получение данных от пользователя
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ВВЕДИТЕ ДАННЫЕ МАССИВА ===");
int column = ReadData("Количество столбцов массива: ");
int row = ReadData("Количество  строк   массива: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ВВЕДИТЕ ДАННЫЕ ИСКОМОГО ЭЛЕМЕНТА ===");
int findeVer = ReadData("Введите позицию по   вертикали: ");
int findeHor = ReadData("Введите позицию по горизонтали: ");


// Генерируем массив
int[,] array = GenArray(row, column);

// Печать массива
PrintArray(array);

// Поиск элемента
    if (findeVer < column && findeHor < row)
    {
        int result = array[findeVer, findeHor];
        // Console.ForegroundColor = ConsoleColor.Red;
        // Console.Write(result + "\t");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nИскомый элемент -> {result}");
    }   
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Индекс находился за пределами массива"); 
    }