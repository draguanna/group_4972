//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 46                                        
//   Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int countRows = ReadInt("Ввкдите количество строк: ");
int countColumn = ReadInt("Ввкдите количество cтолбцов: ");
int [,] arr2D = Fill2DArray(countRows,countColumn,10,100);
Print2DArrayColor(arr2D);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(minValue, maxValue);
        }
    }

    return array2D;
}

// Вывод массиваv
void Print2DArrayColor(int[,] matrix)
{ 
        ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            Console.ForegroundColor = colors[new System.Random().Next(0,16)];
            Console.Write($"{matrix[i, j],2} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}