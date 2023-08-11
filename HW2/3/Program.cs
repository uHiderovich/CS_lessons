/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int Prompt(string message)
{
  Console.Write(message);
  string value = Console.ReadLine();

  return Convert.ToInt32(value);
}

bool IsWeekend(int weekDay)
{
  return weekDay > 5;
}

bool IsValidWeekday(int number)
{
  bool isWeekDay = number > 0 && number <= 7;

  if (!isWeekDay)
  {
    Console.WriteLine("Это He день недели!");
  }

  return isWeekDay;
}

int weekDay = Prompt("Введите день недели >");
if (IsValidWeekday(weekDay))
{
  if (IsWeekend(weekDay))
  {

    Console.WriteLine("Наконец-то выходной");
  }
  else
  {

    Console.WriteLine("Придется поработать");
  }
}