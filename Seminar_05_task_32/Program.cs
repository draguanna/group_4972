//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 32
//   Напишите программу замену элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int[] array = GenArray(12, -9, 9);
PrintArray(array);
InvertArr(array);
PrintArray(array);
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

//Инверсия
void InvertArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) { arr[i] *= -1; }
}