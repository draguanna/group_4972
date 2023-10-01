//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 55                                     
//   Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
//   невозможно, программа должна вывести сообщение для пользователя.

//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countCol = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = 0;
int maxValue = 100;
int[,] matrix = CreateRandomMatrix(countRow, countCol, minValue, maxValue);
PrintMatrix("Исходная матрица", matrix);

// Транспонирование матрицы и вывод результата
if (CanTranspose(matrix))
{
    int[,] transposedMatrix = TransposeMatrix(matrix);
    PrintMatrix("Матрица после замены строк на столбцы:", transposedMatrix);
}
else { Console.WriteLine("\nНевозможно заменить строки на столбцы, так как количество строк и столбцов не совпадает."); }

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

// Вывод двумерного массива на экран.
void PrintMatrix(string msg, int[,] matrix)
{
    Console.WriteLine("\n" + msg);

    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

// Проверка может ли быть матрица транспонирована
bool CanTranspose(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

// Транспортирование матрицы
int[,] TransposeMatrix(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    int[,] transposedMatrix = new int[colCount, rowCount];

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            transposedMatrix[j, i] = matrix[i, j];
        }
    }
    return transposedMatrix;
}