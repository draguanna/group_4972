//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 35
//   Задайте одномерный массив из 123 случайных чисел.
//   Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear(); 
int[] array = GenArray(123, -100, 100);
PrintArray(array); 
int count = CountElem (array);
PrintResult($"Количество элементов, значения которых лежат в отрезке [10,99] равно {count}");

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Генерация массива
int[] GenArray(int len, int lowerBorder, int highBorder)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++) { array[i] = rnd.Next(lowerBorder, highBorder + 1); }
    return array;
}

// Вывод массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Поиск количества элементов в заданных пределах
int CountElem (int[] arr)
{
    int count = 0;
   for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i]<99)
        {
            count++;
        }
    }
    return count;
}