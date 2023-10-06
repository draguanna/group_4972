﻿//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 61                                     
//   Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод N.
int n = ReadInt("Задайте количество строк треугольника Паскаля (N): ");

// Вывод треугольника Паскаля первые N строк.
PrintPascalTriangle(n);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода треугольника Паскаля
void PrintPascalTriangle(int n)
{
    // Cоздание треугольника Паскаля
    int[][] triangle = new int[n][];
    for (int i = 0; i < n; i++)
    {
        triangle[i] = new int[i + 1];
        triangle[i][0] = 1;
        triangle[i][i] = 1;

        for (int j = 1; j < i; j++)
        {
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
        }
    }
    
    // Вывод треугольника Паскаля
    int maxLength = triangle[n - 1][n / 2].ToString().Length;
    for (int i = 0; i < n; i++)
    {
        int padding = (n - i - 1) * maxLength;

        for (int j = 0; j < i + 1; j++)
        {
            Console.Write(triangle[i][j].ToString().PadLeft(maxLength + padding));
            if (j < i) Console.Write("\t");
        }

        Console.WriteLine();
    }
}