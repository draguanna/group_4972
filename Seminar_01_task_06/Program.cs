﻿//Домашнее задание к семинару 01
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear(); // Очистка терминала
int number;      // Объявление целочисленной переменной

//Ввод числа пользователем
Console.Write("Введите целое число: ");
while (!(int.TryParse(Console.ReadLine(), out number)))
     {Console.Write("Введено не целое число, попробуйте еще раз: ");}

//Вывод результата
Console.Write(number%2 ==0 ? $"Число {number} является четным" : $"Число {number} является НЕ четным" );