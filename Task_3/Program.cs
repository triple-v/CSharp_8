// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

System.Console.WriteLine();
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
      else Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}
int[,] CreateMtrixRndInt1(int row1, int col1, int min1, int max1)
{
  int[,] matrix1 = new int[row1, col1];
  Random rnd = new Random();
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
      matrix1[i, j] = new Random().Next(min1, max1);
    }
  }
  return matrix1;
}
void PrintMatrix1(int[,] matrix1)
{
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
      if (j < matrix1.GetLength(1) - 1) System.Console.Write($"{matrix1[i, j]} ");
      else Console.Write($"{matrix1[i, j]} ");
    }
    Console.WriteLine();
  }
}
int[,] MeanArithmeticColumn(int[,] array, int[,] array1)
{
  int[,] matrix2 = new int[array.GetLength(0), array1.GetLength(1)];
  if (array.GetLength(1) != array1.GetLength(0)) Console.WriteLine("Решение отсутствует");
  else
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array1.GetLength(1); j++)
      {
        for (int k = 0; k < array.GetLength(1); k++)
        {
          matrix2[i, j] = matrix2[i, j] + (array[i, k] * array1[k, j]);
        }
      }

    }
  }
  return matrix2;
}
void PrintMatrix2(int[,] matrix2)
{
  for (int i = 0; i < matrix2.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      if (j < matrix2.GetLength(1) - 1) System.Console.Write($"{matrix2[i, j]} ");
      else Console.Write($"{matrix2[i, j]} ");
    }
    Console.WriteLine();
  }
}
int[,] array = CreateMtrixRndInt(2, 2, 1, 10);
PrintMatrix(array);
Console.WriteLine();
int[,] array1 = CreateMtrixRndInt1(2, 2, 1, 10);
PrintMatrix1(array1);
Console.WriteLine();
int[,] arr = MeanArithmeticColumn(array, array1);
Console.WriteLine("Произведение двух матриц:");
Console.WriteLine();
PrintMatrix2(arr);
Console.WriteLine();