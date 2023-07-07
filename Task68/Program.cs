// Задача 68: Напишите программу вычисления функции
// Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Метод рекурсии вычисляет функцию Аккермана
int Ackerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackerman(n - 1, 1);
    else
      return Ackerman(n - 1, Ackerman(n, m - 1));
}

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод выводит результат пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// Основной код программы
// Вводим данные
Console.Clear();
int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");

// Считаем сумму
int sumAckerman = Ackerman(n, m);

// Выводим результат
PrintData("значение функции Аккермана равно: ", sumAckerman);