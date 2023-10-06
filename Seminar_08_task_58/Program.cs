//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 58
//                                          Домашнее задание к семинару 08                                        
//   Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод параметров матриц
int rowCount1, colCount1, rowCount2, colCount2;
GetMatrixParameters("1-ой матрицы", out rowCount1, out colCount1);
GetMatrixParameters("2-ой матрицы", out rowCount2, out colCount2);

// Генерация матриц.
int minValue = -9;
int maxValue = 9;

int[,] matrix1 = CreateRandomMatrix(rowCount1, colCount1, minValue, maxValue);
int[,] matrix2 = CreateRandomMatrix(rowCount2, colCount2, minValue, maxValue);

//  Вывод матриц на экран.
PrintMatrix("\nМатрица 1: ", matrix1);
PrintMatrix("\nМатрица 2: ", matrix2);

if (IsMatrixConsistent (colCount1, rowCount2 )) // Проверка матрицы на согласованность 
{
    // Получение произведения двух матриц и вывод на экран
    int[,] resultMatrix = MatrixMultiplication(matrix1, matrix2);
    PrintMatrix("\nПроизведение двух матриц: ", resultMatrix);
}
else
    { Console.WriteLine("\nУмножение матриц невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");}

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

//Ввод параметров матрицы
void GetMatrixParameters(string matrixName, out int rowCount, out int colCount)
{
    Console.WriteLine($"\nПараметры {matrixName}:");
    rowCount = ReadInt("Введите количество строк m: ");
    colCount = ReadInt("Введите количество столбцов n: ");
}

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
        { Console.Write($"{matrix[i, j],5}"); }

        Console.WriteLine();
    }
}

// Проверка матрицы на согласовнность
 bool IsMatrixConsistent(int colCount1, int rowCount2)
    {
        return colCount1 == rowCount2;
    }

// Произведение двух матриц
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int rowCount1 = matrix1.GetLength(0);
    int colCount1 = matrix1.GetLength(1);
    int colCount2 = matrix2.GetLength(1);
    int[,] resultMatrix = new int[rowCount1, colCount2];

    // Сумма перемножения элементов строк на элементы столбцов
    for (int i = 0; i < rowCount1; i++)
    {
        for (int j = 0; j < colCount2; j++)
        {
            int sum = 0;
            for (int k = 0; k < colCount1; k++)
                { sum += matrix1[i, k] * matrix2[k, j];}
           
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}