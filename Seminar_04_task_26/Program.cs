﻿//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 26
//    Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------

Console.Clear();
int number = ReadData("Введите целое число: ");
int numberLenght = DigitCountLog(number);
PrintResult($"В числе {number} количество цифр равно {numberLenght}");

//------------------------------------------------------------------------------------------------------------------
//                                                    Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод данных с клавиатуры
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Подсчет количества цифр через логарифм
int DigitCountLog( int number)
{
    int numberLenght = (int)Math.Log(number,10)+1;
    return numberLenght;
}

// Подсчет количества цифр через логарифм
int DigitCountWhile(int number)
{
    int length = 0;
    while (number > 0)
    {
        number /= 10;
        length++;
    }
    return length;
}