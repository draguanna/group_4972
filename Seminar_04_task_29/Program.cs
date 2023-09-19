//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 29
//                                      Домашнее задание к семинару 04
//   Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//   * Ввести с клавиатуры длину массива и диапазон значений элементов
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear(); // Очистка консоли

//Ввод данных
int len = ReadData ("Введите количество элементов в массиве: ");
int lowerLimit = ReadData ("Введите границу нижнего диапозона: ");
int upperLimit = ReadData ("Введите границу верхнего диапозона: ");
int[] array = GenArray(len,lowerLimit,upperLimit);
PrintArray(array);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод данных с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Генерация массива
int[] GenArray(int len, int lowerLimit, int upperLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++) { array[i] = rnd.Next(lowerLimit, upperLimit+1); }
    return array;
}

// Вывод массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}