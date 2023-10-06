//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 60
//                                          Домашнее задание к семинару 08                                        
//   Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно
//   выводить массив, добавляя индексы каждого элемента.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();

// Ввод парметров трехмерного массива
int xSize = ReadInt("Введите размерность x: ");
int ySize = ReadInt("Введите размерность y: ");
int zSize = ReadInt("Введите размерность z: ");

// Генерация трехмерного массива и вывод на экран.
int[,,] array3D = Generate3DArray(xSize, ySize, zSize);
Print3DArrayWithIndexes(array3D);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци трехмерного массива, заполненного случайными неповторяющимися двузначными числами.
int[,,] Generate3DArray(int xSize, int ySize, int zSize)
{
    int[,,] array = new int[xSize, ySize, zSize];
    Random random = new Random();
    HashSet<int> usedNumbers = new HashSet<int>();

    for (int x = 0; x < xSize; x++)
    {
        for (int y = 0; y < ySize; y++)
        {
            for (int z = 0; z < zSize; z++)
            {
                int randomNumber;
                do
                {
                  randomNumber = random.Next(10, 100); // Генерируем двузначное число
                } while (usedNumbers.Contains(randomNumber)); // Добавляем число в массив, только если оно уникально

                usedNumbers.Add(randomNumber);
                array[x, y, z] = randomNumber;
            }
        }
    }

    return array;
}

// Вывод трехмерного массива с указанием индексов
void Print3DArrayWithIndexes(int[,,] array3D)
{
    Console.WriteLine($"\nМассив размером {array3D.GetLength(0)} x {array3D.GetLength(1)} x {array3D.GetLength(2)}");

    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            { Console.Write($"{array3D[x, y, z]}({x},{y},{z}) "); }

            Console.WriteLine();
        }
    }
}