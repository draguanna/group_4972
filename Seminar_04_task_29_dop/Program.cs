﻿//------------------------------------------------------------------------------------------------------------------
//                                                  Дополнительная задача
//                                              Домашнее задание к семинару 04
//   Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------

Console.Clear();  // Очистка консоли

string inputNames = ReadData("Введите имена через точку с запятой: "); // Ввод данных
string[] arrayOfNames = SplitLine(inputNames); // Создание массива имен
int nameIndex = GetName(arrayOfNames.Length);  // Выборка случайного имени
PrintResult(arrayOfNames[nameIndex]);          // Вывод случайного имени на экран

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод данных с клавиатуры
string ReadData(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}

// Создание массива из имен
string[] SplitLine(string inputNames)
{
    return inputNames.Split(", ");
}

// Генерация случайного числа в массиве
int GetName(int len)
{
    Random rnd = new Random();
    return rnd.Next(0, len);
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}