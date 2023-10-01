//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 57                                     
//   Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
//   информацию о том, сколько раз встречается элемент входных данных.

//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countCol = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = 0;
int maxValue = 10;
int[,] matrix = CreateRandomMatrix(countRow, countCol, minValue, maxValue);
PrintMatrix("Заданная матрица", matrix);

// Создание и вывод частотного словаря
Dictionary<int, int> frequencyDictionary = CreateFrequencyDictionary(matrix);
PrintDictionary(frequencyDictionary);

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

// Заполнение частотного словаря
Dictionary<int, int> CreateFrequencyDictionary(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            if (frequencyDictionary.ContainsKey(matrix[i, j]))
            {
                frequencyDictionary[matrix[i, j]]++;
            }
            else
            {
                frequencyDictionary[matrix[i, j]] = 1;
            }
        }
    }

    return frequencyDictionary;
}

// Вывод  частотного словаря на экран
void PrintDictionary(Dictionary<int, int> frequencyDictionary)
{
    Console.WriteLine("\nЧастотный словарь:");
    foreach (var kvp in frequencyDictionary)
    {
        Console.WriteLine($"{kvp.Key} встречается {kvp.Value} раз{(kvp.Value > 1 ? "а" : "")}");
    }
}