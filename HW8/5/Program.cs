/*
Дополнительная задача

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

int[,] CreateArray(int size)
{
  int[,] array = new int[size, size];
  string direction = "right";

  int row = 0;
  int col = 0;

  int diff = 0;

  for (int i = 1; i <= size * size; i++)
  {
    // Console.WriteLine($"row: {row}, col: {col}, diff: {diff}");
    array[row, col] = i;

    if (direction == "right")
    {
      if (col == (size - 1 - diff))
      {
        direction = "down";
        row++;
      }
      else
      {
        col++;
      }
    }
    else if (direction == "down")
    {
      if (row == (size - 1 - diff))
      {
        direction = "left";
        col--;
      }
      else
      {
        row++;
      }
    }
    else if (direction == "left")
    {
      if (col == diff)
      {
        direction = "top";
        row--;
        diff++; // меняем сдвиг только когда идем вверх, так как нужно уменьшить кол-во шагов
      }
      else
      {
        col--;
      }
    }
    else if (direction == "top")
    {
      if (row == diff)
      {
        direction = "right";
        col++;
      }
      else
      {
        row--;
      }
    }
  }

  return array;
}

void Print2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]}\t");
    Console.WriteLine();
  }
}

// int rows = InputNum("Введите количество строк: ");
int size = InputNum("Введите количество строк и столбцов: ");

Print2DArray(CreateArray(size));