//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 31
//   Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
//   отрицательных и положительных элементов массива.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int[] array = GenArray(12, -9, 9);
PrintArray(array);
(int pos, int neg) sum = NegativePositiveSum(array);
Console.WriteLine($"Сумма положительных чисел {sum.pos}\nСумма отрицательных чисел {sum.neg}");

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

// Подсчет сумм
(int, int) NegativePositiveSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) { posSum += arr[i];}
        else { negSum += arr[i];}
    }
    return (posSum,negSum);
}