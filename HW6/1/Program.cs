/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int Prompt(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int CountGreaterThanZero(int[] array)
{
  int sum = 0;

  foreach (var item in array)
  {
    sum += item > 0 ? 1 : 0;
  }

  return sum;
}

int[] CreateArray(int length)
{
  int[] array = new int[length];

  for (int i = 0; i < length; i++)
  {
    array[i] = Prompt("Введите число: ");
  }

  return array;
}

int arrayLength = Prompt("Введите длину массива: ");
int[] array = CreateArray(arrayLength);

Console.WriteLine($"Количество чисел больше 0:  {CountGreaterThanZero(array)}");