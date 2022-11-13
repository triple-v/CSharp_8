// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine();
int[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
  int[,] matrix = new int[row, col];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max);
    }
  }
  return matrix;
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j]} ");
      else Console.Write($"{matrix[i, j]}");
    }
    Console.WriteLine();
  }
}
int SearchMinimumSumString(int[,] matrix)
{
  int minsum = Int32.MaxValue;
  int indexLine = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum = sum + matrix[i, j];
    }
    if (sum < minsum)
    {
      minsum = sum;
      indexLine++;
    }
  }
  return indexLine;
}
int[,] array = CreateMtrixRndInt(4, 4, 1, 10);
PrintMatrix(array);
Console.WriteLine();
int ar = SearchMinimumSumString(array);
Console.WriteLine($"Строка под номером {ar} имеет наименьшую сумму элементов");
