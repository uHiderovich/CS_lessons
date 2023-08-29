/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int Prompt(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int length, int minValue, int maxValue)
{
  int[] result = new int[length];
  Random random = new Random();

  for (int i = 0; i < length; i++)
  {
    result[i] = random.Next(minValue, maxValue + 1);
  }

  return result;
}

void PrintArray(int[] array)
{
  Console.Write('[');
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.Write($"{array[array.Length - 1]}");
  Console.Write(']');
}

int arrayLength = Prompt("Введите длину массива: ");
int minValue = Prompt("Введите минимальное значение: ");
int maxValue = Prompt("Введите максимальное значение: ");

if (minValue > maxValue)
{
  Console.WriteLine("Минимальное значение не может быть больше максимального");
}

PrintArray(CreateArray(arrayLength, minValue, maxValue));