// Задача №1

Console.WriteLine("Введите число а ");
int a = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine()!); 
if (a == b*b)
{
 Console.WriteLine("Число а являеться квадратом b");   
}
else
{
 Console.WriteLine("Число а НЕ являеться квадратом b");   
}