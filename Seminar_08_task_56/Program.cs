//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 56
//                                          Домашнее задание к семинару 08                                        
//   Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
//   суммой элементов. 
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод парметров матрицы.
int rowCount = ReadInt("Введите количество строк m: ");
int colCount = ReadInt("Введите количество cтолбцов n: ");

// Генерация матрицы и вывод на экран
int minValue = -9;
int maxValue = 9;
int[,] matrix = CreateRandomMatrix(rowCount, colCount, minValue, maxValue);
PrintMatrix("\nСгенерированная матрица: ", matrix);

// Поиск строки с наименьшей суммой элементов и вывод результатов
int minSumRowIndex = FindRowWithMinSum(matrix);
PrintResult(minSumRowIndex);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными целыми значениями.
int[,] CreateRandomMatrix(int rowCount, int colCount, int minValue, int maxValue)
{
    Random random = new Random();
    int[,] matrix = new int[rowCount, colCount];

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        { matrix[i, j] = random.Next(minValue, maxValue + 1); }
    }

    return matrix;
}

// Вывод двумерного массива на экран.
void PrintMatrix(string message, int[,] matrix)
{
    Console.WriteLine(message);

    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        { Console.Write($"{matrix[i, j],4}"); }

        Console.WriteLine();
    }
}

// Поиск индекса строки с наименьшей суммой элементов
int FindRowWithMinSum(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minSumRowIndex = -1;
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        int rowSum = 0;

        // Суммирвоание элементов строки
        for (int j = 0; j < colCount; j++)
        {
            rowSum += matrix[i, j];
        }
        // Сравнение с минимальной суммой
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }

    return minSumRowIndex;
}

// Вывод результата 
void PrintResult(int minSumRowIndex)
{
    if (minSumRowIndex != -1)
        { Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {minSumRowIndex}"); }
    else
        { Console.WriteLine("Массив пуст."); }
}