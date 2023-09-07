// Домашнее задание к семинару 01
// Задача 4:Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear(); // Очистка терминала
int [] numbArray = new int[3]; // Объяление массива

// Ввод чисел пользователем
Console.WriteLine("Введите поочередно три целых числа.");
for(int i = 0; i < numbArray.Length; i++)
{
    Console.Write($"Число[{i}]= ");
    while (!(int.TryParse(Console.ReadLine(), out numbArray[i])))
    {Console.Write("Введено не целое число, попробуйте еще раз: ");}
}
Console.Write($"max = "+ numbArray.Max());

