//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 20
//   Напишите программу, которая принимает на вход координаты двух точек
//   и находит расстояние между ними в 2D пространстве.
//------------------------------------------------------------------------------------------------------------------


// (Метод) Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// (Метод) Расчет расстояния между точками
double Calc2DDist(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return result;
}

// (Метод) Вывод данных
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Тело программы
Console.Clear(); // Очистка терминала
int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");

double result = Calc2DDist(x1, y1, x2, y2);
PrintResult("Расстояние между заданными точками: " + result);