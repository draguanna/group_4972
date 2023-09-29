//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 50
//                                          Домашнее задание к семинару 07                                        
//   Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,и возвращает значение 
//   этого элемента или же указание, что такого элемента нет  
//   * Заполнить массив числами фиббоначи.Ту цифру, которую ищем подсветить другим цветом.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
// Ввод парметров матрицы.
int rowCount = ReadInt("Введите количество строк m: ");
int colCount = ReadInt("Введите количество cтолбцов n: ");

// Генерация матрицы.
int[,] fibonacciMatrix = GenerateFibonacciMatrix(rowCount, colCount);

// Ввод позиции элемента.
int rowIndex = ReadInt("Введите индекс элемента по строкам: ");
int colIndex = ReadInt("Введите индекс элемента по столбцам: ");

// Поиск элемента в матрице и вывод результата.
int element = FindNumberByPosition(fibonacciMatrix, rowIndex, colIndex);
PrintResult(element, rowIndex, colIndex);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумервного массива, состоящего из чисел Фибоначчи.
int[,] GenerateFibonacciMatrix(int rowCount, int colCount)
{
    int[,] matrix = new int[rowCount, colCount];
    int first = 0;
    int second = 1;

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            matrix[i, j] = first;
            int temp = first + second;
            first = second;
            second = temp;
        }
    }
    return matrix;
}

// Поиск элемента в массиве.
int FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int result = -1; // Возвращаем если такого элемента нет

    int countRow = matrix.GetLength(0);
    int countColumn = matrix.GetLength(1);

    if (rowPosition - 1 < countRow && columnPosition - 1 < countColumn)
    {
        result = matrix[rowPosition - 1, columnPosition - 1];
    }
    return result;
}

// Вывод результата на экран.
void PrintResult(int result, int rowIndex, int colIndex)
{
    if (result == -1) { Console.WriteLine("Такой элемент не существует"); }
    else
    {
        Console.WriteLine($"\nЗначение элемента на позиции [{rowIndex}, {colIndex}]: {result}");
        PrintMatrixWithHighlight(fibonacciMatrix, rowIndex, colIndex);
    }
}

// Вывод двумерного массива на экран с подсвеченным элементом.
void PrintMatrixWithHighlight(int[,] matrix, int rowIndex, int colIndex)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {   
            // Проверяем является ли элемент искомым и подсвечиваем его
            if (i == rowIndex - 1 && j == colIndex - 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
            else { Console.ForegroundColor = ConsoleColor.White; }

            Console.Write($"{matrix[i, j],-10} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}