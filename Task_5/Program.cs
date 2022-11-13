// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер стороны квадратной матрицы:");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
  Console.WriteLine("Введено некорректное число. Введите число больше нуля.");
}
else
{
  Console.WriteLine();
  int[,] matrix = new int[n, n];
  void FillingSpiral(int[,] matrix)
  {
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
      matrix[i, j] = temp;
      temp++;
      if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
      else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
      else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
      else
        i--;
    }
  }
  void OutiputNumberSpiral(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if (array[i, j] / 10 <= 0)
          Console.Write($" {array[i, j]} ");
        else Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
    }
  }
  FillingSpiral(matrix);
  OutiputNumberSpiral(matrix);
  Console.WriteLine();
}