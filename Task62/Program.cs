// Задача 62. Напишите программу,
// которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Метод вывода массива по спирали

void WriteArray (int[,] array)
{
Console.Clear();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n=========== Задача № 62 ===========\n");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===  ВЫВОДИМ МАССИВ 4Х4 ПО СПИРАЛИ ===\n");
Console.ForegroundColor = ConsoleColor.Cyan;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


//  Генерация массива
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}


 // Вывод результата

WriteArray(sqareMatrix);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n============ КОНЕЦ ============\n"); 