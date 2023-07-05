// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

// Метод вычисляет произведение двух массивов (матриц)
void Mylti2DArr(int[,] arr1, int[,] arr2, int[,] resArr)
{

    for (int i = 0; i < resArr.GetLength(0); i++)
    {
        for (int j = 0; j < resArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            resArr[i, j] = sum;
        }
    }
}


// Основной код программы

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n=========== Задача № 58 ===========");

// Получение данных от пользователя
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n========= ВВЕДИТЕ ДАННЫЕ ДЛЯ КОРРЕКТНОГО РЕШЕНИЯ ЗАДАЧИ =========");
Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй");

// Ввод параметров  первой и второй матриц
Console.ForegroundColor = ConsoleColor.Cyan;
int row1 = ReadData("\nКоличество строк первой матрицы: ");
int colFirstRowSec = ReadData("Количество СТРОК первой и СТОЛБЦОВ второй матрицы: ");
int column2 = ReadData("Количество столбцов второй матрицы: ");
int range = ReadData("Диапазон элементов массива от 0 до -> ");
Console.WriteLine();


// Генерируем первый двумерный массив
int[,] arr2DFirst = GenArray(row1, colFirstRowSec, range);

// Генерируем второй двумерный массив
int[,] arr2DSecond = GenArray(colFirstRowSec, column2, range);


// Выводим первый и второй двумерные массивы
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("ПЕРВЫЙ ДВУМЕРНЫЙ МАССИВ");
PrintArray(arr2DFirst);
Console.WriteLine();
Console.WriteLine("ВТОРОЙ ДВУМЕРНЫЙ МАССИВ");
PrintArray(arr2DSecond);

// Вычисляем произведение двух матриц
int[,] res2DArr = new int[row1, column2];
Mylti2DArr(arr2DFirst, arr2DSecond, res2DArr);

// 6. Выводим результат
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("ПРОИЗВЕДЕНИЕ ДВУХ МАТРИЦ");
PrintArray(res2DArr);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n============ КОНЕЦ ============\n");