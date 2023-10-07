﻿//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 66                                     
//                                          Домашнее задание к семинару 09
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод данных.
int m = ReadInt("Введите значение M: ");
int n = ReadInt("Введите значение N: ");

// Печать строки.
Console.WriteLine((m > n)
                  ? $"Сумма натуральных чисел от {n} до {m} равна {SumNaturalNumbers(n, m)}"
                  : $"Сумма натуральных чисел от {m} до {n} равна {SumNaturalNumbers(m, n)}");

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Рекурентный метод поиска суммы чисел от M до N.
int SumNaturalNumbers(int m, int n)
{
    return m == n
    ? m
    : m + SumNaturalNumbers(m + 1, n);
}