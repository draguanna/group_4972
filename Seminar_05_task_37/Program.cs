//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 37
//   Найдите произведение пар чисел в одномерном массиве. 
//   Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int[] array = GenArray(11, 0, 10);
PrintArray(array);
int[] sumArray = ConvertArray(array);
PrintArray(sumArray);
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
// Генерация нового массива
int[] ConvertArray(int[] arr)
{
int[] outArray = new int[arr.Length / 2];
for (int i = 0; i < arr.Length / 2; i++) { outArray[i] = arr[i] * arr[arr.Length - 1 - i]; }
return outArray;
}