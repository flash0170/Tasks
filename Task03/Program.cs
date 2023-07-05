﻿// Задача №3
// Напишите программу, которая на вход принимает
// число сообшает день недели

// Вводим данные с консоли первое число
Console.WriteLine("Введите число от 1 до 7");
string? inputNum = Console.ReadLine();

// if проверка на нулевое значение
if (inputNum != null)
{
    //конвертация строки в число
    int nameDay = int.Parse(inputNum);
       
    // объявляем ПУСТУЮ переменную
    string outDayOfWeek = string.Empty;

    // Перебираем оператором Switch и присваиваем значение
    switch (nameDay)
    {
        case 1: outDayOfWeek = "Понедельник"; break;
        case 2: outDayOfWeek = "Вторник"; break;
        case 3: outDayOfWeek = "Среда"; break;
        case 4: outDayOfWeek = "Четверг"; break;
        case 5: outDayOfWeek = "Пятница"; break;
        case 6: outDayOfWeek = "Суббота"; break;
        case 7: outDayOfWeek = "Воскресенье"; break;
        default: outDayOfWeek = "Это не день недели, повторите ввод"; break;
    }

    // Вывод результата
    Console.WriteLine(outDayOfWeek);

}