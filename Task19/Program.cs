﻿// Задача 19: Напишите программу, которая принимает на вход  
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Метод читает данные от пользователя
 int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

 //Метод выводит результат пользователю
 void PrintData(string msg )
 {
     Console.WriteLine(msg);
 }

// Метод определения палиндрома
bool PaliTest(int num)
{
     bool res = false;
     int d1 = num / 10000;
     int d2 = (num / 1000) % 10;
     int d3 = (num / 10) % 10;
     int d4 = num % 10;
     res = ((d1 == d4) && (d2 == d3)) ? true : false;
     return res;
 }

// Объявляем переменную FiveNumDig и присваиваем ей значение введенное пользователем (Метод ReadData)
int FiveNumDig = ReadData("Введите 5-ти значное число:");

// Вызываем метод PaliTest и скармливаем ему переменную FiveNumDig
bool answer = PaliTest(FiveNumDig);
//Выводим ответ пользователю на экран
if(answer == true) PrintData("Число: " + FiveNumDig + " является палиндромом");
if(answer == false) PrintData("Число: " + FiveNumDig + " не является палиндромом");