//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 27
//                                      Домашнее задание к семинару 04
//   Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//   * Сделать оценку времени алгоритма через вещественные числа и строки
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear(); // Очистка консоли
int number = ReadData("Введите целое число: "); // Ввод числа с клавиатуры

CalculateAndPrintSum("Метод деления", number, SumDigitDiv); // Сумма методом деления
CalculateAndPrintSum("Метод строки", number, SumDigitStr);  // Сумма методом строки


//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод данных с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывод результата
void CalculateAndPrintSum(string methodName, int number, Func<int, int> calculator)
{
    DateTime startTime = DateTime.Now;
    int sum = calculator(number);
    TimeSpan executionTime = DateTime.Now - startTime;
    Console.WriteLine($"\n{methodName}:\nСумма цифр числа {number} = {sum}\nВремя исполнения {executionTime}");
}

// Вычисление суммы цифр через вещественные числа
int SumDigitDiv(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

//Вычисление суммы цифр через строку
int SumDigitStr(int number)
{
    string numberStr = number.ToString();
    int result = 0;

    foreach (char digitChar in numberStr) { result += int.Parse(digitChar.ToString()); }
    return result;
}