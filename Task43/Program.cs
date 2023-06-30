// Задача 43: Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine() !);
}

double xVolume(double b1, double k1, double b2, double k2)
{
    double xVol = (b2 - b1) / (k1 - k2);
    return xVol;
}

double yVolume(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double b1 = ReadData("Введите значение b1: \nb1 -> ");
double k1 = ReadData("Введите значение k1: \nk1 -> ");
double b2 = ReadData("Введите значение b2: \nb2 -> ");
double k2 = ReadData("Введите значение k2: \nk2 -> ");

double x = xVolume(b1, k1, b2, k2);
double y = yVolume(b1, k1, x);

Console.WriteLine("\n===РЕЗУЛЬТАТ===");
Console.WriteLine("Значение Х = " + x);
Console.WriteLine("Значение Y = " + y);