// Домашнее задание к семинару 01
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear(); // Очистка терминала
int firstNum, secondNum; // Объявление целочисленных переменных

// Ввод пользователем первого числа
Console.Write("Введите первое число: ");
while (!(int.TryParse(Console.ReadLine(), out firstNum)))
     {Console.Write("Введено не целое число, попробуйте еще раз: ");}

// Ввод пользователем второго числа
Console.Write("Введите второе число: ");
while (!(int.TryParse(Console.ReadLine(), out secondNum)))
    {Console.Write("Введено не целое число, попробуйте еще раз: ");}

//Вывод сведений о минимальном и максимальном числе
if (firstNum > secondNum) {Console.Write($"max = {firstNum}, min = {secondNum}");}
    else if (firstNum < secondNum) {Console.Write($"max = {secondNum}, min = {firstNum}");}
        else {Console.Write($"max = min = {firstNum}");}