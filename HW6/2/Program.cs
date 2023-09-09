/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int COEFFICIENT = 0;
int CONSTANT = 1;
int COORD_X = 0;
int COORD_Y = 1;

double Prompt(string message)
{
  Console.WriteLine(message);
  return Convert.ToDouble(Console.ReadLine()!);
}

double[] CreateLineData(int numberOfLine)
{
  double[] data = new double[2];

  data[COEFFICIENT] = Prompt($"Введите коэффицент k{numberOfLine}");
  data[CONSTANT] = Prompt($"Введите константу b{numberOfLine}");

  return data;
}

double[] FindIntersectionPoint(double[] line1, double[] line2)
{
  double[] Point = new double[2];

  Point[COORD_X] = (line1[CONSTANT] - line2[CONSTANT]) / (line2[COEFFICIENT] - line1[COEFFICIENT]);
  Point[COORD_Y] = line1[COEFFICIENT] * Point[COORD_X] + line1[CONSTANT];

  return Point;
}

bool IsValidLines(double[] line1, double[] line2)
{
  if (line1[COEFFICIENT] == line2[COEFFICIENT])
  {
    string errorMessage = line1[CONSTANT] == line2[CONSTANT]
      ? "Прямые совпадают"
      : "Прямые параллельны";

    Console.WriteLine(errorMessage);

    return false;
  }

  return true;
}

double[] lineData1 = CreateLineData(1);
double[] lineData2 = CreateLineData(2);

if (IsValidLines(lineData1, lineData2))
{
  double[] IntersectionPoint = FindIntersectionPoint(lineData1, lineData2);

  Console.WriteLine($"Точка пересечения уравнений y={lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]}");
  Console.WriteLine($"имеет точки пересечения {IntersectionPoint[COORD_X]} и {IntersectionPoint[COORD_Y]}");
}