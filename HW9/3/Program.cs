/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1)

int Ackermann(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0)
  {
    return Ackermann(m - 1, 1);
  }
  else
  {
    return Ackermann(m - 1, Ackermann(m, n - 1));
  }
}

bool IsValidateNaturalNums(int start, int end)
{
  return start > 0 && end > 0 && start <= end;
}

int start = InputNum("Введите начало: ");
int end = InputNum("Введите конец: ");

if (IsValidateNaturalNums(start, end))
{
  Console.WriteLine(Ackermann(start, end));
}
