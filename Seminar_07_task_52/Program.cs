//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 52
//                                          Домашнее задание к семинару 07                                        
//   Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
//   * Вывести среднее арифметическое по диагоналям. При выводе матрицы, диагонали окрасить в разные цвета.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countCol = ReadInt("Введите количество cтолбцов n: ");

// Генерация матрицы 
int minValue = -10;
int maxValue = 10;
int[,] matrix = CreateRandomMatrix(countRow, countCol, minValue, maxValue);
PrintMatrixWithColoredDiagonals(matrix);

// Находим и выводим среднее арифметическое по диагоналям
double mainDiagonalAverage = CalculateDiagonalAverage(matrix, true);
double antiDiagonalAverage = CalculateDiagonalAverage(matrix, false);

Console.WriteLine($"\nСреднее арифметическое по главной диагонали: {mainDiagonalAverage:0.00}");
Console.WriteLine($"Среднее арифметическое по побочной диагонали: {antiDiagonalAverage:0.00}");


//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными целыми значениями.
int[,] CreateRandomMatrix(int countRow, int countCol, int minValue, int maxValue)
{
    Random random = new Random();
    int[,] matrix = new int[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

// Вывод матрицы с окрашенными диагоналями
void PrintMatrixWithColoredDiagonals(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Red; // Главная диагональ - красный цвет
            }
            else if (i + j == colCount - 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue; // Побочная диагональ - синий цвет
            }
            else
            {
                Console.ResetColor(); // Сбрасываем цвет
            }

            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.ResetColor(); // Сбрасываем цвет
}

// Подсчет среднего арифм. в диагоналях
double CalculateDiagonalAverage(int[,] matrix, bool isMainDiagonal)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    double sum = 0;

    if (isMainDiagonal) // Если диагональ главная
    {
        for (int i = 0; i < rowCount; i++) { sum += matrix[i, i]; }
    }
    else // Если диагональ побочная
    {
        for (int i = 0; i < rowCount; i++) { sum += matrix[i, colCount - 1 - i]; }
    }

    return sum / rowCount;
}