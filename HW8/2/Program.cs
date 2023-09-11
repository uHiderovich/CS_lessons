/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
      matrix[i, j] = random.Next(1, 101);
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

int RowIndexWithMinSum(int[,] matrix)
{
  int minSum = 0;
  int resultRowIndex = 0;

  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    minSum += matrix[0, i];
  }

  for (int i = 1; i < matrix.GetLength(0); i++)
  {
    int tempSum = 0;

    for (int j = 1; j < matrix.GetLength(1); j++)
    {
      tempSum += matrix[i, j];
    }

    if (minSum > tempSum)
    {
      minSum = tempSum;
      resultRowIndex = i;
    }
  }

  return resultRowIndex;
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int[,] matrix = Create2DArray(rows, columns);

Fill2DArray(matrix);
Print2DArray(matrix);

int rowIndexWithMinSum = RowIndexWithMinSum(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowIndexWithMinSum + 1}");