// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int DayWeek = int.Parse(Console.ReadLine()!);
if (DayWeek < 8 & DayWeek > 0)
{
    if (DayWeek == 6 || DayWeek == 7) Console.Write($"{DayWeek}-й день недели выходной"); 
    else Console.Write($"{DayWeek}-й день недели рабочий");
}
else
{
Console.Write($"Цифра/число {DayWeek} не является днем недели");
} 