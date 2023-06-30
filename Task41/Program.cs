// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


string ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

int CountPositivNumber(string str)
{
    int count = 0;
    string strWoSp = str.Replace(" ", "");
    string[] strArr = strWoSp.Split(",");
    int[] intArr = new int[strArr.Length];
    for (int i = 0; i < intArr.Length; i++) intArr[i] = int.Parse(strArr[i]);

    for (int i = 0; i < intArr.Length; i++) if (intArr[i] > 0) count++;

    return count;
}

string sequenceNumbers = ReadDataStr("Введите через запятую последовательность чисел: ");

int countPosNum = CountPositivNumber(sequenceNumbers);

Console.WriteLine("Количество положительных чисел равно: " + countPosNum);


