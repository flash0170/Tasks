// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


 int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine()!);
 }

 void PrintData(string msg, double res)
 {
     Console.WriteLine(msg + res);
 }


 double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
 {
     double res = 0;
     res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
     return res;
 }

 int coordX1 = ReadData("Введите координату x1");
 int coordX2 = ReadData("Введите координату x2");
 int coordY1 = ReadData("Введите координату y1");
 int coordY2 = ReadData("Введите координату y2");
 int coordZ1 = ReadData("Введите координату z1");
 int coordZ2 = ReadData("Введите координату z2");

 double lenght = CalcLen(coordX1,coordX2,coordY1,coordY1,coordZ1,coordZ2);

 PrintData("Расстояние между точками равно: ", lenght);