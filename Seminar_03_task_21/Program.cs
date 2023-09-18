//------------------------------------------------------------------------------------------------------------------
//                                         Домашнее задание к семинару 3
//                                                  Задача 21
//   Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//   * Сделать метод загрузки точек (распарсить строку)
//------------------------------------------------------------------------------------------------------------------

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
        double result = Math.Sqrt(
              Math.Pow((pointB[0] - pointA[0]), 2)
            + Math.Pow((pointB[1] - pointA[1]), 2)
            + Math.Pow((pointB[2] - pointA[2]), 2)
            );
        return result;


    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 7;
            x2 = -5;
            x3 = 0;
            y1 = 1;
            y2 = -1;
            y3 = -9;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
    }
}