//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 43
//                                          Домашнее задание к семинару 06
//   Напишите программу, которая найдёт точку пересечения двух прямых,
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//   (*) Найдите площадь треугольника образованного пересечением 3 прямых
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

(double k, double b)[] functionParams = ReadFunctionParams();      // Ввод параметров функции с клавиатуры.
(double x, double y)[] points = FindIntersections(functionParams); // Поиск координат точек пересечения линий.
double area = CalculateTriangleArea(points);                       // Вычисление площади треугольника.
PrintResult(points, area);                                         // Вывод результатов в консоль.

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод параметров функции с клавиатуры.
(double k, double b)[] ReadFunctionParams()
{
    var functionParams = new (double k, double b)[3];

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Введите коэффициенты для {i + 1}-й прямой (y = k{i + 1} * x + b{i + 1}):");
        functionParams[i].k = ReadDouble($"k{i + 1} = ");
        functionParams[i].b = ReadDouble($"b{i + 1} = ");
    }

    return functionParams;
}

// Считывание числа с плавающей запятой.
double ReadDouble(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

// Поиск координат точек пересечения линий.
(double x, double y)[] FindIntersections((double k, double b)[] functionParams)
{
    var points = new (double x, double y)[3];

    for (int i = 0; i < 3; i++)
    {
        int nextIndex = (i + 1) % 3;
        points[i].x = (functionParams[nextIndex].b - functionParams[i].b) / (functionParams[i].k- functionParams[nextIndex].k);
        points[i].y = functionParams[i].k * points[i].x + functionParams[i].b;
    }

    return points;
}

// Вычисление площади треугольника по координатам его точек.
double CalculateTriangleArea((double x, double y)[] points)
{
    return 0.5 * Math.Abs(points[0].x * (points[1].y - points[2].y) + points[1].x * (points[2].y - points[0].y) + points[2].x * (points[0].y - points[1].y));
}

// Вывод результатов в консоль.
void PrintResult((double x, double y)[] points, double area)
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Точка пересечения прямых {i + 1} и {((i + 1) % 3) + 1}: ({points[i].x}, {points[i].y})");
    }
    
    Console.WriteLine($"Площадь треугольника: {area}");
}
