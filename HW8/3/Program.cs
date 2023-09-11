/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
  Random random = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = i + j;
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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
  int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        result[i, j] += matrix1[i, k] * matrix2[k, j];
      }
    }
  }

  return result;
}

bool IsValidMatrices(int[,] matrix1, int[,] matrix2)
{
  int cols1 = matrix1.GetLength(1);
  int rows2 = matrix2.GetLength(0);

  bool result = cols1 == rows2;

  if (!result)
  {
    Console.Write("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
    return false;
  }

  return true;
}

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");

// Не валидная матрица для проверки
// int[,] matrix1 = {
//   { 1, 2},
//   { 4, 5}
// };
int[,] matrix1 = {
  { 1, 2, 3},
  { 4, 5, 6}
};

int[,] matrix2 = {
  {7, 8},
  {9, 10},
  {11, 12}
};

// int[,] matrix1 = Create2DArray(rows, columns);
// int[,] matrix2 = Create2DArray(rows, columns);

// Fill2DArray(matrix1);
// Fill2DArray(matrix2);

if (IsValidMatrices(matrix1, matrix2))
{
  Print2DArray(matrix1);
  Console.WriteLine();
  Print2DArray(matrix2);
  Console.WriteLine();

  int[,] resultMatris = MatrixMultiplication(matrix1, matrix2);
  Print2DArray(resultMatris);
}

