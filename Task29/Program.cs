// Задача 29: Напишите программу, которая
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите длину массива: ");
int arrFirst = ReadData("Введите левый диапазон эл-тов: ");
int arrEnd = ReadData("Введите правый диапазон эл-тов: ");

int[] arr = Gen1DArr(arrLen, arrFirst, arrEnd);

Print1DArr(arr);