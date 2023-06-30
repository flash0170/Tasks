// Задача 36: Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int SumPos (int [] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        res += arr[i];
    }
    return res;
}

int[] testArr = GenArray(10,1,10);

PrintArray(testArr);

int oddValueSum = SumPos(testArr);

PrintData("Сумма элементов, стоящих на нечётных позициях равна: " + oddValueSum);