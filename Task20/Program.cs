// Задача №20: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


int XA = Prompt ("Введите координаты точки XA: ");
int YA = Prompt ("Введите координаты точки YA: ");
int XB = Prompt ("Введите координаты точки XB: ");
int YB = Prompt ("Введите координаты точки YB: ");

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

double AB = Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA));
Console.WriteLine(AB);