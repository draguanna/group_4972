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
int rowCount = ReadInt("Введите количество строк m: ");
int colCount = ReadInt("Введите количество cтолбцов n: ");

// Генерация матрицы.
int minValue = 0;
int maxValue = 9;
int[,] matrix = CreateRandomMatrix(rowCount, colCount, minValue, maxValue);

// Поиск среднего арифметического по диагоналям.
double[] averageValues = FindAverages(matrix);

// Создание цветового набора для вывода результатов.
int countDiagonals = matrix.GetLength(1) + matrix.GetLength(0) - 1;
ConsoleColor[] diagonalsColors = CreateConsoleColorArray(countDiagonals);

// Вывод матрицы и результатов подсчета на экран.
PrintMatrixColoredDiagonals("\nСгенерированный массив: ", matrix, diagonalsColors);
AverageValuesOutput(averageValues, diagonalsColors);

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

    // Опередление значений массива
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
            { matrix[i, j] = random.Next(minValue, maxValue + 1); }
    }

    return matrix;
}

// Поиск среднего арифметического каждой диагонали.
double[] FindAverages(int[,] matrix)
{
    // Используемые переменные
    int countDiagonals = matrix.GetLength(1) + matrix.GetLength(0) - 1;
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    double[] averageValues = new double[countDiagonals];

    // Поиск среднего арифметического.
    for (int i = 0; i < countDiagonals; i++)
    {
        int sum = 0;
        int count = 0;

        int col = (i < colCount) ? i : colCount - 1;
        int row = (i < colCount) ? 0 : i - colCount + 1;

        while (row < rowCount && col >= 0 )
        {
            sum += matrix[row, col];
            count++;
            col--;
            row++;
        }

        averageValues[i] = (double)sum / count;
    }

    return averageValues;
}

// Получение набора цветов для дигоналей.
ConsoleColor[] CreateConsoleColorArray(int length)
{
    Random random = new Random();
    ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

    // Заполнение массива цветов.
    ConsoleColor[] newColors = new ConsoleColor[length];
    for (int i = 0; i < length; i++) { newColors[i] = colors[i % colors.Length]; }
    return newColors;
}

// Вывод двумерного массива на экран.
void PrintMatrixColoredDiagonals(string message, int[,] matrix, ConsoleColor[] matrixColors)
{
    Console.WriteLine(message);

    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            Console.ForegroundColor = matrixColors[i + j];
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

// Вывод средних значений по диагоналям.
void AverageValuesOutput(double[] averageValues, ConsoleColor[] matrixColors)
{
    Console.WriteLine();
    Console.WriteLine("Средние значения диагоналей:");

    for (int i = 0; i < averageValues.Length; i++)
    {
        Console.ForegroundColor = matrixColors[i];
        Console.Write($"[{i}]:{averageValues[i]:F2}  ");
    }
    Console.ResetColor();
}