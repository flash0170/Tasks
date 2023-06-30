// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементом массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("Задаем массив вещественных чисел -> [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void PrintData(int res)
{
        Console.Write($"Разница между максимальным и минимальным элементом массива равна: {res}");
}

int MaxMinSubtraction(int[] arr)
{
    int max = int.MinValue;
    int min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

int[] Array1 = GenArray(10, 1, 10);

PrintArray(Array1);

PrintData(MaxMinSubtraction(Array1));