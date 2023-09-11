/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
  return new int[rows, columns];
}

void Fill2DArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = 2 * i + j;
    }
  }
}

void Print2DArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }

    Console.WriteLine();
  }
}

void SortArrayByRowIndex(int[,] matrix, int rowIndex)
{
  int colsCount = matrix.GetLength(1);

  for (int i = 0; i < colsCount; i++)
  {
    for (int j = i + 1; j < colsCount; j++)
    {
      if (matrix[rowIndex, i] < matrix[rowIndex, j])
      {
        int temp = matrix[rowIndex, i];
        matrix[rowIndex, i] = matrix[rowIndex, j];
        matrix[rowIndex, j] = temp;
      }
    }
  }
}

void SortMatrixByRows(int[,] matrix)
{
  for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
  {
    SortArrayByRowIndex(matrix, rowIndex);
  }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] matrix = Create2DArray(rows, columns);

Fill2DArray(matrix);
Print2DArray(matrix);
SortMatrixByRows(matrix);
Console.WriteLine();
Print2DArray(matrix);