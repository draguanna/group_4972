//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 33
//   Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();                                                              // Очистка консоли
int[] array = GenArray(12, -9, 9);                                            // Генерация массива
PrintArray(array);                                                            // Вывод массива на экран
int elemet = ReadData("Введите число, которое необходимо найти в массиве: "); // Ввод искомого элемента
int index = FindElement(array, elemet);                                       // Поиск индекса

// Вывод результата
if (index > 0) {PrintResult($"Элемент найден, индекс:{index}");} 
else {PrintResult("Элемент не найден");} 

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

// Ввод данных с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Поиск элемента
int FindElement(int[] arr, int element)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == element)
        {
            return i;
        }
    }
    return -1;
}