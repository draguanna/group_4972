//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 34
//   Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int decimalNumber = ReadData("Введите десятичное число: ");
string binaryNumber = DecimalToBinarySimple(decimalNumber);
PrintResult($"Двоичное представление: {binaryNumber}");

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод числа с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вывод результата на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Метод для преобразования десятичного числа в двоичное
string DecimalToBinarySimple(int decimalNumber)
{
    return Convert.ToString(decimalNumber, 2);
}

// Рекурентный метод
string DecToBinRec(int number)
{
    return number == 0 ? "" : DecToBin(number / 2) + Convert.ToString(number % 2);
}
