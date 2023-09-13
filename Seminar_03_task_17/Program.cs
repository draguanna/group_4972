﻿//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 17
//  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер
//  четверти плоскости, в которой находится эта точка. 
//------------------------------------------------------------------------------------------------------------------

Console.Clear(); // Очистка терминала

// 1) Ввести Х
// 2) Ввести Y
// 3) Поиск ответа
// 4) Вывод результата

// Метод на ввод данных
int ReadData (string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// Метод определения номера плоскости по координатам точки
int QuterTest (int x, int y)
{
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return 0;
}

// Метод вывода результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите координату X: ");
int y = ReadData("Введите координату Y: ");
int result = QuterTest(x,y);
PrintResult("Точка находится в четверти №"+ result);
