﻿//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 40
//   Напишите программу, которая принимает на вход три числа и проверяет,
//   может ли существовать треугольник с сторонами такой длины.
//------------------------------------------------------------------------------------------------------------------

//                                                Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

//Ввод сторон треугольника a,b,c
int a = ReadInt("Введите первое число: ");
int b = ReadInt("Введите второе число: ");
int c = ReadInt("Введите третье число: ");

//Проверка является ли треугольником
bool result = TriangleTest(a,b,c);
PrintResult($"{result}");


//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод числа с клавиатуры
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вывод результата на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//Проверка является ли треугольником
bool TriangleTest (int a, int b, int c)
{   
     return !(a+b <= c || b+c <= a || a+c <= b);
}

