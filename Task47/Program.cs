// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadData(string msg)
{
    Console.ForegroundColor = (ConsoleColor.DarkBlue);
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

double[,] GenArray(int row, int column)
{
    int i = 0; int j = 0;
    double[,] arr = new double[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 99) + new Random().NextDouble(), 2);
            j++;
        }
        i++;
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    Console.ForegroundColor = (ConsoleColor.Green);
    Console.WriteLine("\n=== ДВУМЕРНЫЙ МАССИВ ===");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor.DarkBlue);
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

Console.ForegroundColor = (ConsoleColor.Green);
Console.WriteLine("\n=== ВВЕДИТЕ ДАННЫЕ ===");
int n = ReadData("Количество строк массива: ");
int m = ReadData("Количество столбцов массива: ");

double[,] arr2D = GenArray(n, m);

PrintArray(arr2D);