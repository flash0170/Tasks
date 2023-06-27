// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadData(string message)
{
     Console.Write(message);
     return int.Parse(Console.ReadLine()!);
}
double Number(int numberN, int numberP) 
{
   //int number = Math.Pow(int numberN, int numberP); 
   double number = 1;
    for (int i = 0; i < numberP; i++)
    {
        number = Math.Pow(numberN, numberP);
    }
    return number;  
}

bool NumberP(int numberP)
{
    if (numberP < 0)
    {
        Console.WriteLine("Степень не может быть меньше нуля, исправте ошибку и повторите ввод");
        return false;
    }
    return true;
}
int numberN = ReadData("Введите число: ");
int numberP = ReadData("Введите степень: ");
if (NumberP(numberP))
{
Console.WriteLine($"Число {numberN} в степени {numberP} равно {Number(numberN, numberP)}");
}