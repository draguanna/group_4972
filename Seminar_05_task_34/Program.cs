//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 34
//                                      Домашнее задание к семинару 05
//   Задайте массив, заполненный случайными положительными трёхзначными числами
//   Напишите программу, которая покажет количество чётных чисел в массиве.
//   * Отсортировать массив методом пузырька
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Генерация массива из случайных чисел и вывод 
int[] array = GenerateRandomArray(10, 100, 999);
PrintArray("Исходный массив:\n", array);

//Подсчет четных чисел в массиве и вывод результата
int evenCount = CountEvenNumbers(array);
PrintResult($"Количество четных элементов в массиве: {evenCount}");

// Сортировка массива методом пузырька и вывод
BubbleSort(array);
PrintArray("Отсортированный массив:\n", array);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Генерация массива
int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
    return array;
}

//Подсчет четных чисел в массиве
int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0) { count++; }
    }
    return count;
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Сортировка методом пузырька
void BubbleSort(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (array[j] > array[j + 1])
            {
                // Меняем местами элементы
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
}

// Вывод массива
void PrintArray(string msg, int[] array)
{
    Console.Write(msg +"[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}