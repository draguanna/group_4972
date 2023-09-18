//------------------------------------------------------------------------------------------------------------------
//                                         Домашнее задание к семинару 3
//                                                  Задача 19
//   Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//   * Решить через словарь
//------------------------------------------------------------------------------------------------------------------

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        if (number >= 10000 && number <= 99999)
        {
            int temp = number;
            int revNumber = 0;

            while (temp != 0)
            {
                revNumber = revNumber * 10 + temp % 10;     // Переворачиваем число по цифрам
                temp /= 10;                                 // Отбрасываем последнюю цифру
            }

            if (number == revNumber) { return true; }
            else { return false; }
        }
        else
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
