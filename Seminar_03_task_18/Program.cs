//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 18
//   Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой
//   четверти (x и y).
//------------------------------------------------------------------------------------------------------------------

Console.Clear(); // Очистка терминала

// 1) Ввести номер четверти
// 2) Ответить на вопрос
// 3) Вывести ответ

// (Метод) Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// (Метод) Определить выдаваемые данные
string QuterBorderAsk(int numQut)
{
    if (numQut == 1) return "x>0 && y>0";
    if (numQut == 2) return "x<0 && y>0";
    if (numQut == 3) return "x<0 && y<0";
    if (numQut == 4) return "x>0 && y<0";
    return "empty";
}

// (Метод) Вывод данных
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Программа 
int planeNumber = ReadData("Введите номер плоскости ");
string result = QuterBorderAsk(planeNumber);
PrintResult("К данной плоскости принадлежат координаты: " + result);
