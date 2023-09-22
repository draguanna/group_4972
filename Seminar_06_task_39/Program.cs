//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 39
//   Напишите программу, которая перевернёт одномерныймассив 
//   (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//------------------------------------------------------------------------------------------------------------------

//                                                Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Генерация массива из случайных чисел и вывод
int[] array = GenerateRandomArray(10, 0, 9);
PrintArray("Сгенерированный массив:\n", array);

// Переворачиваем массив
int[] swappArr = SwapNewArray(array);
PrintArray("Исходный массив:\n", array);
PrintArray("Перевернутый массив:\n", swappArr);

SwapArray(array);
PrintArray("Исходный перевернутый массив:\n", array);


//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
    return array;
}

// Вывод массива
void PrintArray(string msg, int[] array)
{
    Console.Write(msg + "[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Перестановка элементов в новом массиве
int[] SwapNewArray(int[] array)
{
    int[] outArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++) { outArr[array.Length - 1 - i] = array[i]; }
    return outArr;
}

// Перестановка элементов в текущем массиве
void SwapArray(int[] array)
{
   // int buferElement = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        // buferElement = array[array.Length - 1 - i];
        // array[array.Length - 1 - i] = array[i];
        // array[i] = buferElement;

        // Вместо использования буферной переменной
        (array[array.Length-1-i],array[i] )=(array[i], array[array.Length-1-i]); 
    }
}
