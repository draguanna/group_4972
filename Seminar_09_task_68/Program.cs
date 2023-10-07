﻿//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 68                                     
//                                          Домашнее задание к семинару 09
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод данных.
int m = ReadInt("Введите значение M: ");
int n = ReadInt("Введите значение N: ");

int result = AckermannFunction(m, n);
Console.WriteLine($"Значение функции  A({m},{n}) = {result}");

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вычисление функции Акермана.
int AckermannFunction(int m, int n)
{
    if (m == 0) {return n + 1;}
    else if (m > 0 && n == 0) {return AckermannFunction(m - 1, 1);}
         else {return AckermannFunction(m - 1, AckermannFunction(m, n - 1));}
}