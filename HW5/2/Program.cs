/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int Prompt(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int SumOddPositions(int[] arrayNumbers)
{
  int sum = 0;

  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if (i % 2 == 1)
    {
      sum += arrayNumbers[i];
    }
  }

  return sum;
}

int[] CreateRandomArray(int length, int minValue = -1000, int maxValue = 1000)
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
int[] randomArray = CreateRandomArray(arrayLength);
int countEven = SumOddPositions(randomArray);

Console.WriteLine($"Сумма чисел на нечетных позициях {countEven}");