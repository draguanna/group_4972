//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 49     
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//------------------------------------------------------------------------------------------------------------------
//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int countRows = ReadInt("Введите количество строк: ");
int countColumn = ReadInt("Введите количество cтолбцов: ");
int[,] arr2D = Fill2DArray(countRows, countColumn, 0, 10);
Print2DArray("\nИсходный массив:", arr2D);
ModifyArray (arr2D);
Print2DArray("\nМодифицированный массив:", arr2D);

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

// Вывод массива
void Print2DArray(string msg, int[,] matrix)
{
    Console.WriteLine(msg);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) { Console.Write($"{matrix[i, j],2} "); }
        Console.WriteLine();
    }
}

// Модификация массива
void ModifyArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] = (int)Math.Pow(matrix[i,j],2);
        }
    }
}