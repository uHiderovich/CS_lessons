/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

void GetNaturalNumbers(int start)
{
  if (start == 0)
  {
    Console.WriteLine(start);
    return;
  }

  Console.WriteLine(start);
  GetNaturalNumbers(start - 1);
}

int start = InputNum("Введите число с которона начнется высод: ");
GetNaturalNumbers(start);