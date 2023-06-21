// Задача 23: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

string LineBuilder(int n, int p)

{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t ";
    }
    return s;
}

int num = ReadData("Введите N: ");

string line1 = LineBuilder(num, 1);
string line2 = LineBuilder(num, 3);

PrintData(line1,line2);