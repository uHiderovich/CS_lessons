/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int Prompt(string message)
{
  System.Console.Write(message);
  string value = Console.ReadLine();

  return Convert.ToInt32(value);
}

int number = Prompt("Введите трех значное число: ");

if (number < 100 || number >= 1000)
{
  Console.WriteLine("Вы ввели не трех значное число, пожалуйста повторите");
  return;
}

Console.WriteLine($"Введенное число {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра {secondRank}");