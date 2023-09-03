/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int Prompt(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

double[] CreateRandomArray(int length, int minValue = -10, int maxValue = 10)
{
  double[] result = new double[length];
  Random random = new Random();

  for (int i = 0; i < length; i++)
  {
    result[i] = Math.Round(random.NextDouble() * random.Next(minValue, maxValue), 2);
  }

  return result;
}

double GetFromArray(double[] arrayNumbers, string param)
{
  double result = arrayNumbers[0];

  foreach (double number in arrayNumbers)
  {
    if (param == "max" && number > result)
    {
      result = number;
    }

    if (param == "min" && number < result)
    {
      result = number;
    }
  }

  return result;
}

int arrayLength = Prompt("Введите длину массива: ");
double[] randomArray = CreateRandomArray(arrayLength);
double minValue = GetFromArray(randomArray, "min");
double maxValue = GetFromArray(randomArray, "max");

Console.WriteLine($"Разница между максимальным и минимальным элементами: {maxValue - minValue}");