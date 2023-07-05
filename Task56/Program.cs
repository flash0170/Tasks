// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Метод ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
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
void PrintArray(int[,] arr, int GreenLine)
{
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ИСХОДНЫЙ ДВУМЕРНЫЙ МАССИВ ===\n");
Console.ForegroundColor = ConsoleColor.White;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (GreenLine==i)
            {
            Console.ForegroundColor = ConsoleColor.Green; // Выделяем в массиве искомый элемент
            arr[i, j] = arr[GreenLine, j];
            Console.Write("");
            }
        Console.Write(arr[i, j] + "\t");
        Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine("");
    }
}

// Метод считает сумму элементов строки массива
int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

// Основной код программы

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n=========== Задача № 56 ===========");

// Получение данных от пользователя
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ВВЕДИТЕ ДАННЫЕ МАССИВА ===\n");
Console.ForegroundColor = ConsoleColor.Cyan;
int row = ReadData("Количество строк    массива: ");
int column = ReadData("Количество столбцов массива: ");
int range = ReadData("Диапазон элементов массива от 0 до -> ");

// Генерируем двумерный массив
int[,] array = GenArray(row, column, range);



// Находим строку с наименьшей суммой
int minSumLine = 0;
int sumLine = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLine(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
minSumLine = minSumLine + 1;

// Печатаем двумерный массив
PrintArray(array, minSumLine-1);


// Выводим результат на экран
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Строка с наименьшей суммой: " + minSumLine);
Console.WriteLine("Наименьшая   сумма   равна: " + sumLine);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n============ КОНЕЦ ============\n");