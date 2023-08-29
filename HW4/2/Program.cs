/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Prompt(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int BumbersSum(int a)
{
  int result = 0;

  while (a > 0)
  {
    result += a % 10;
    a = a / 10;
  }

  return result;
}

int numberBase = Prompt("Введите число: ");

Console.WriteLine($"Сумма цифр в числе {numberBase} равна {BumbersSum(numberBase)}");