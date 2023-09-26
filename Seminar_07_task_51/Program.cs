//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 51                                        
//    Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами
//    (0,0); (1;1) и т.д.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int countRows = ReadInt("Введите количество строк: ");
int countColumn = ReadInt("Введите количество cтолбцов: ");
int[,] arr2D = Fill2DArray(countRows, countColumn, 0, 10);
Print2DArray("\nИсходный массив:", arr2D);
int sum = CalculateDiagonalSum(arr2D);
PrintResult($"суммы элементов главной диагонали: {sum}");

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

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

// Подсчет суммы элементов главной диагонали
int CalculateDiagonalSum(int[,] matrix)
{
        int sum = 0;
        int min = matrix.GetLength(0)>matrix.GetLength(1)
            ? matrix.GetLength(1)
            : matrix.GetLength(0);

        for (int i = 0; i <  min ; i++)
        {
            sum += matrix[i, i];
        }
        return sum;
}

// Вывод результата 
void PrintResult (string msg)
{
    Console.WriteLine(msg);
}