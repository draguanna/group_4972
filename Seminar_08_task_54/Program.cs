//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 54
//                                          Домашнее задание к семинару 08                                        
//   Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод параметров матрицы.
int rowCount = ReadInt("Введите количество строк m: ");
int colCount = ReadInt("Введите количество столбцов n: ");

// Генерация матрицы и вывод на экран.
int minValue = 0;
int maxValue = 9;
int[,] matrix = CreateRandomMatrix(rowCount, colCount, minValue, maxValue);
PrintMatrix("\nИсходная матрица: ", matrix);

// Сортировка элементов по убыванию в каждой строке матрицы и вывод результата.
SortMatrixRows(matrix);
PrintMatrix("\nОтсортированная матрица: ", matrix);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация двумерного массива, заполненного случайными целыми значениями.
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

// Сортировка элементов в строках матрицы.
void SortMatrixRows(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    for (int i = 0; i < rowCount; i++)
        { SortRowDesc(matrix, i); }
}

// Сортировка элементов в строке по убыванию.
void SortRowDesc(int[,] matrix, int rowIndex)
{
    int colCount = matrix.GetLength(1);

    // Используем сортировку вставками для упорядочивания строки.
    for (int i = 1; i < colCount; i++)
    {
        int key = matrix[rowIndex, i];
        int j = i - 1;

        while (j >= 0 && matrix[rowIndex, j] < key)
        {
            matrix[rowIndex, j + 1] = matrix[rowIndex, j];
            j--;
        }

        matrix[rowIndex, j + 1] = key;
    }
}