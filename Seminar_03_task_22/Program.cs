//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 22
//   Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//------------------------------------------------------------------------------------------------------------------

//Методы

//Ввод данных пользователем с клавиатуры
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Получение строки с числами в нужной степени
string BuildLine(int num, int pow)
{
    string res = string.Empty;
    for (int i = 1; i <= num; i++) { res+= String.Format("{0,5}\u2502", Math.Pow(i, pow)); }
    return res;
}

// Нарисовать линию таблицы
void PrintLine(int count, string type)
{
    string line = string.Empty;
    char firstChar = '+';
    char middleChar = '+';
    char lastChar = '+';

    //Определить набор символов в линии в зависимости от ее положения
    if (type == "top")  // Если линия сверху таблицы
    {
        firstChar = '\u250C';  // ┌
        middleChar = '\u252C'; // ┬
        lastChar = '\u2510';   // ┐
    }
    if (type == "inside") // Если линия внутри таблицы
    {
        firstChar = '\u251C';  // ├
        middleChar = '\u253C'; // ┼
        lastChar = '\u2524';   // ┤
    }
      if (type == "bottom") // Если линия внизу таблицы
    {
        firstChar = '\u2514';  // └
        middleChar = '\u2534'; // ┴
        lastChar = '\u2518';   // ┘
    }

    line += firstChar;   // Установка первого символа в зависимости от положения линии в таблице
    for (int i = 0; i < 13; i++) { line += "\u2500"; } // Обрамление наименования строк.

    // Обрамление вдоль столбцов 
    for (int i = 0; i < count; i++)
    {
        line += middleChar;
        for (int j = 0; j < 5; j++) { line += "\u2500"; }
    }
    
    line+=lastChar;          // Установка последнего символа в зависимости от положения линии в таблице
    Console.WriteLine(line); // Печать собранной линии
}

//Вывод строки с числами
void PrintResult(string rowName, string rowString)
{
    Console.WriteLine($"\u2502{rowName,13}\u2502{rowString}");
}

//Тело программы

Console.Clear(); // Очистка терминала
int number = ReadData("Введите положительное число N");
string sourceString = BuildLine(number, 1);
string resultString = BuildLine(number, 2);

PrintLine(number, "top");
PrintResult ("Число",sourceString );
PrintLine(number, "inside");
PrintResult ("Квадрат числа", resultString );
PrintLine(number, "bottom");
