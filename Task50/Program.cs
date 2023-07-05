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
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}


// Метод для заполнения двумерного массива целыми числами
int[,] GenArray(int row, int column)
{
    int i = 0;
    int j = 0;
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

// Метод вывода двумерного массива в консоль с найденым элементом
void PrintArray(int[,] arr, int rowP, int columnP)
{
int i = 0;
int j = 0; 
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ДВУМЕРНЫЙ МАССИВ ===\n");
     for (i = 0; i < arr.GetLength(0); i++)
    {
        for (j = 0; j < arr.GetLength(1); j++)
        {
            if (rowP==i && columnP==j)
            {
            Console.ForegroundColor = ConsoleColor.Red; // Выделяем в массиве искомый элемент
            arr[i, j] = arr[rowP, columnP];
            Console.Write("");
            }
        Console.Write(arr[i, j] + "\t");               // Выводим массив
        Console.ForegroundColor = ConsoleColor.Yellow;
           
        }
        Console.WriteLine(); 
    }

     if (rowP < i && columnP < j)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nИскомый элемент -> {arr[rowP, columnP]}"); // Вывод искомого элемента отдельной строкой
    }   
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nИндекс находился за пределами массива"); // Сообщение об ошибке
    }


}

// Получение данных от пользователя
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ВВЕДИТЕ ДАННЫЕ МАССИВА ===");
int row = ReadData("Количество  строк   массива: ");
int column = ReadData("Количество столбцов массива: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n=== ВВЕДИТЕ ДАННЫЕ ИСКОМОГО ЭЛЕМЕНТА ===");
int findeHor = ReadData("Введите позицию по горизонтали: ");
int findeVer = ReadData("Введите позицию по   вертикали: ");

// Генерируем двумерный массив
int[,] array = GenArray(row, column);

// Печатаем двумерный массив
PrintArray(array, findeVer, findeHor);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n============== КОНЕЦ ==================");

