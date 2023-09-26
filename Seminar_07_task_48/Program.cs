//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 48                                        
//   Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//   Выведите полученный массив на экран.
//------------------------------------------------------------------------------------------------------------------
//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int countRows = ReadInt("Введите количество строк: ");
int countColumn = ReadInt("Введите количество cтолбцов: ");
int[,] arr2D = Fill2DSumIndex(countRows, countColumn);
Print2DArray(arr2D);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация двумерного массива
int[,] Fill2DSumIndex(int countRow, int countColumn)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = i + j;
        }
    }
    return array2D;
}

// Вывод массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) { Console.Write($"{matrix[i, j],2} "); }
        Console.WriteLine();
    }
}