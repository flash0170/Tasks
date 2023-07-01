// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Метод ввода данных с консоли
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ВВЕДИТЕ ДАННЫЕ МАССИВА ===");
int ReadData(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}


// Метод для заполнения массива целыми (int) числами
double[,] GenArray(int row, int column)
{
    int i = 0; int j = 0;
    double[,] arr = new double[row, column];
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


// Метод вывода массива в консоль
void PrintArray(double[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n=== ДВУМЕРНЫЙ МАССИВ ===");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" I\tII\tIII\tIV\t...>>>\n");

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


// Метод печати результата
void PrintResult(double[] arr)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n== СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ ПО СТОЛБЦАМ == ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" I\tII\tIII\tIV\t...>>>\n");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}


// Метод подсчета среднего арифметического по столбцам
double[] MeanColum(double[,] arr)
{
    double[] means = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            means[i] = means[i] + arr[j, i];
        }
        means[i] = means[i] / arr.GetLength(0);
        means[i] = Math.Round(means[i], 1);
    }
    return means;
}

// Получение данных от пользователя
int row = ReadData("Количество строк    массива: ");
int column = ReadData("Количество столбцов массива: ");

// Генерируем массив
double[,] array = GenArray(row, column);

// Считаем среднее арифметическое по столбцам
double[] average = MeanColum(array);

// Выводим массив
PrintArray(array);

// Выводим результат
PrintResult(average);