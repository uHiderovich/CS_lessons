/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int index = 1;

while (index <= number)
{
  if (index % 2 == 0)
  {
    string prefix = index > 2 ? ", " : "";

    Console.Write(prefix + index);
  }

  index++;
}