﻿//------------------------------------------------------------------------------------------------------------------
//                                        Домашнее задание к семинару 02
//                                                  Задача 10. 
//   Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//------------------------------------------------------------------------------------------------------------------

Console.Clear(); // Очистка терминала
int number;      // Объявление целочисленной переменной для числа
int index = 2;   // Задаем индекс интересующей для вывода цифры (по условию это 2)

// Ввод числа пользователем
Console.Write("Введите положительное целое трехзначное число: ");
while ((!(int.TryParse(Console.ReadLine(), out number))) || (!(number > 99 && number <= 999)))                         
{ Console.Write("Неверный формат числа, попробуйте еще раз: "); }

//Вывод результата
char[] digitChar = number.ToString().ToCharArray();
Console.WriteLine(number + " -> " + digitChar[index - 1]);