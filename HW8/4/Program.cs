/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

int[] ShuffleArray(int[] array)
{
  Random random = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    int randomIndex = random.Next(array.Length);
    int temp = array[i];
    array[i] = array[randomIndex];
    array[randomIndex] = temp;
  }

  return array;
}

int[] RamdomNumbersArray()
{
  int[] array = new int[90];

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = i + 10;
  }

  return ShuffleArray(array);
}

int[,,] Create3DArray(int rows, int columns, int depth)
{
  int[,,] array = new int[rows, columns, depth];
  int[] randomNumbers = RamdomNumbersArray();
  int index = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = randomNumbers[index++];
      }
    }
  }

  return array;
}

void Print3DArrayWithIndex(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write("\n");
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
      }

    }
    Console.WriteLine();
  }
}

void Print3DArray(int[,,] array)
{
  int level1 = array.GetLength(0);
  int level2 = array.GetLength(1);
  int level3 = array.GetLength(2);

  Console.WriteLine("[");

  for (int i = 0; i < level1; i++)
  {
    Console.WriteLine("  [");

    for (int j = 0; j < level2; j++)
    {
      Console.Write("    [");

      for (int k = 0; k < level3; k++)
      {
        Console.Write($"{array[i, j, k]}");

        if (k < level3 - 1)
        {
          Console.Write(", ");
        }
      }

      Console.Write("]");

      if (j < level2 - 1)
      {
        Console.WriteLine(",");
      }
      else
      {
        Console.WriteLine();
      }
    }

    Console.Write("  ]");

    if (i < level1 - 1)
    {
      Console.WriteLine(",");
    }
    else
    {
      Console.WriteLine();
    }
  }

  Console.WriteLine("]");
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int depth = InputNum("Введите глубину: ");

int[,,] array = Create3DArray(rows, columns, depth);
Print3DArray(array);