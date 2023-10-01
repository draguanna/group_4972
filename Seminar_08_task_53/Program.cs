//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 53                                     
//   Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countCol = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = -10; int maxValue = 10;
int[,] matrix = CreateRandomMatrix(countRow, countCol, minValue, maxValue);
PrintMatrix(matrix);

// Изменение массива и его вывод
ChangeMatrix(matrix);
PrintMatrix(matrix);

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

// Вывод матрицы на экран.
void PrintMatrix(int[,] matrix)
{   Console.WriteLine();

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

void ChangeMatrix(int [,] matrix)
{
    int temp = 0;
    for (int j = 0; j<matrix.GetLength(1); j++)
    {
        temp = matrix[0,j];
        matrix [0,j] = matrix [matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = temp;
    }
}