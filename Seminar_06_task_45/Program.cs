//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 44
//   Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
//------------------------------------------------------------------------------------------------------------------

//                                                Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
// Генерация массива из случайных чисел и вывод 
int[] array = GenerateRandomArray(10, 0, 20);
PrintArray("Исходный массив:\n", array);

// Копирование массива
int[] newArray = CopyArray(array);
PrintArray("Скопированный массив:\n", newArray);

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

// Вывод массива
void PrintArray(string msg, int[] array)
{
    Console.Write(msg +"[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Копирование массива
int[] CopyArray (int [] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i<array.Length;i++) {newArray[i]=array[i];}
    return newArray;
}