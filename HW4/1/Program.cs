/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Prompt(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int MathPow(int a, int b)
{
  int result = 1;

  while (b > 0)
  {
    result *= a;
    b -= 1;
  }

  return result;
}

int numberBase = Prompt("Введите основание: ");
int degree = Prompt("Введите степернь: ");

Console.WriteLine($"Число {numberBase} в степени {degree} равно {MathPow(numberBase, degree)}");