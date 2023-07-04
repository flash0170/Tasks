// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Метод ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

// Метод сортировки от большего к меньшему
void BubleSortLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Метод для заполнения двумерного массива целыми (int) числами
int[,] GenArray(int row, int column, int range)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, range);
            j++;
        }
        i++;
    }
    return arr;
}


// Метод вывода двумерного массива в консоль
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

// Основной код программы

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n=========== Задача № 54 ===========");
// Получение данных от пользователя
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ВВЕДИТЕ ДАННЫЕ МАССИВА ===\n");
Console.ForegroundColor = ConsoleColor.Blue;
int row = ReadData("Количество строк массива: ");
int column = ReadData("Количество столбцов массива: ");
int range = ReadData("Диапазон элементов массива от 0 до -> ");

// Генерируем двумерный массив
int[,] array = GenArray(row, column, range);

// Печатаем двумерный массив
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ИСХОДНЫЙ ДВУМЕРНЫЙ МАССИВ ===\n");
Console.ForegroundColor = ConsoleColor.White;
PrintArray(array);

// Сортируем элементы массива по убыванию
BubleSortLines(array);

// Печатаем  отсортированный двумерный массив
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ОТСОРТИРОВАННЫЙ ДВУМЕРНЫЙ МАССИВ ===\n");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(array);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n=========== КОНЕЦ ===========\n");