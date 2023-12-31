﻿//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 63                                     
//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

int num = ReadInt("Введите N: ");
GenLineRec(num);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Рекурентный метод печати натуральных чисел  от N до 1
void GenLineRec(int num)
{
    Console.Write(num + " ");
    if (num > 1) { GenLineRec(num - 1); }
}
