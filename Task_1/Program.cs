// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void DescedingSort(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
      for (int ind = 0; ind < array.GetLength(1) - 1; ind++)
      {
        if (array[i, ind] < array[i, ind + 1])
        {
          int temp = 0;
          temp = array[i, ind];
          array[i, ind] = array[i, ind + 1];
          array[i, ind + 1] = temp;
        }
      }
    }
  }
}
int[,] array = CreateMtrixRndInt(4, 4, 1, 10);
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine($"Массив, отсортированный по убыванию имеет следующий вид:");
Console.WriteLine();
DescedingSort(array);
PrintMatrix(array);