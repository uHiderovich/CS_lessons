/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int Prompt(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int CountEven(int[] arrayNumbers)
{
  int count = 0;

  foreach (int number in arrayNumbers)
  {
    if (number % 2 == 0)
    {
      count += 1;
    }
  }

  return count;
}

int[] CreateRandomArray(int length, int minValue, int maxValue)
{
  int[] result = new int[length];
  Random random = new Random();

  for (int i = 0; i < length; i++)
  {
    result[i] = random.Next(minValue, maxValue + 1);
  }

  return result;
}

int arrayLength = Prompt("Введите длину массива: ");
int[] randomArray = CreateRandomArray(arrayLength, 100, 999);
int countEven = CountEven(randomArray);

Console.WriteLine($"Кол-во четных чисел в массиве {countEven}");