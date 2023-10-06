//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 62
//                                          Домашнее задание к семинару 08                                        
//   Напишите программу, которая заполнит спирально массив 4 на 4.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Заполнение и вывод спирального массива.
int n = 4;
int[,] spiralArray = FillSpiralArray(n);
PrintSpiralArray("Заполненный массив:", spiralArray);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Заполнение массива спиралью.
int[,] FillSpiralArray(int n)
{
    int[,] array = new int[n, n];
    int currentValue = 1;
    int left = 0, right = n - 1, top = 0, bottom = n - 1;

    while (currentValue <= n * n)
    {
        // Заполняем верхнюю строку слева направо.
        for (int i = left; i <= right; i++)
        {
            array[top, i] = currentValue++;
        }
        top++;

        // Заполняем правый столбец сверху вниз.
        for (int i = top; i <= bottom; i++)
        {
            array[i, right] = currentValue++;
        }
        right--;

        // Заполняем нижнюю строку справа налево.
        for (int i = right; i >= left; i--)
        {
            array[bottom, i] = currentValue++;
        }
        bottom--;

        // Заполняем левый столбец снизу вверх.
        for (int i = bottom; i >= top; i--)
        {
            array[i, left] = currentValue++;
        }
        left++;
    }
    return array;
}

// Вывод спирального массива на экран.
void PrintSpiralArray(string message, int[,] array)
{
    Console.WriteLine(message);
    int n = array.GetLength(0);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}