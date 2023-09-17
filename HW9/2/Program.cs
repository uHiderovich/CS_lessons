/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

int SumNaturalNums(int m, int n)
{
  if (m == n)
  {
    return m;
  }

  return m + SumNaturalNums(m + 1, n);
}

bool IsValidateNaturalNums(int start, int end)
{
  return start > 0 && end > 0 && start <= end;
}

int start = InputNum("Введите начало: ");
int end = InputNum("Введите конец: ");

if (IsValidateNaturalNums(start, end))
{
  Console.WriteLine(SumNaturalNums(start, end));
}
