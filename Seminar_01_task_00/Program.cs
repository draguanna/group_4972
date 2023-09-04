/*Задача №0
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Например: 4 -> 16 -3 -> 9 -7 -> 49 */

Console.WriteLine("Введите число ");
string? inputNum = Console.ReadLine(); //??"0"; // Считываем данные с консоли

if (inputNum != null)
{
    /*Длинная версия решения
    int num = int.Parse(inputNum);                 // Парсим введеное число
    int result = num*num;                          // Находим квадрат числа
    Console.WriteLine($"Квадрат числа: {result}"); // Выводим данные в консоль */

    // Коротка версия решения в одну строку
    Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(inputNum), 2));
}

