//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 36
//                                      Домашнее задание к семинару 05
//   Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//   * Найдите все пары в массиве и выведите их пользователю с указанием позиции в массиве
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Генерация массива из случайных чисел и вывод
int[] array = GenerateRandomArray(20, 0, 9);
PrintArray("Сгенерированный массив:\n", array);

// Подсчет суммы элементов, стоящих на нечётных позициях и вывод результата
int sum = SumOddNumPos(array);
PrintResult($"Сумма элементов, стоящих на нечётных позициях в массиве: {sum}");

// Поиск пар в массиве и вывод результата
FindAndPrintPairs(array);

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
    Console.Write(msg + "[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Подсчет суммы элементов, стоящих на нечётных позициях в массиве
int SumOddNumPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2) { sum += array[i]; }
    return sum;
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Поиск пар в массиве и вывод результата
void FindAndPrintPairs(int[] array)
{
    Console.WriteLine("Пары в массиве:");

    // Объявляем словарь <TKey> число, <TValue> будет его индекс в массиве
    Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

    // // Для каждого элемента в массиве проверяется, содержится ли он уже в словаре seenNumbers
    for (int i = 0; i < array.Length; i++)
    {
        if (seenNumbers.ContainsKey(array[i]))
        {
            // Если число содержится в словаре, значит нашли пару. Выводим на экран пару чисел и их адреса в массиве.
            // Само число из словаря удаляем
            Console.WriteLine($"{array[i]},{array[i]} -> [{seenNumbers[array[i]]}], [{i}]");
            seenNumbers.Remove(array[i]);
        }
        else
        {   // Если число не содержится в словаре, добавляем его.
            seenNumbers.Add(array[i],i);
        }
    }
}