﻿//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 12
//  Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//  Если второе число некратно первому, то программа выводит остаток от деления. 
//------------------------------------------------------------------------------------------------------------------

Console.Clear(); // Очистка терминала

// Ввод данных
Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "0");

// Результат
if (numB % numA == 0) { Console.WriteLine("Первое число кратно второму"); }
else { Console.WriteLine("Первое число не кратно второму, остаток " + numB % numA); }
