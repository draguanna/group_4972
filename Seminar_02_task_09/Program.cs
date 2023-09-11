//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 9
//  Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.
//------------------------------------------------------------------------------------------------------------------

Console.Clear(); // Очистка терминала

void Variant1() // Способ 1
{
    Console.WriteLine("Способ 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    // Разложили число на цифры
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit) { Console.WriteLine(firstDigit); }
    else { Console.WriteLine(secondDigit); }
}

void Variant2() // Способ 2
{
    Console.WriteLine("Способ 2");
    System.Random numberGenerator1 = new System.Random();
    int number1 = numberGenerator1.Next(10, 100);
    Console.WriteLine(number1);
    Console.WriteLine((number1 / 10 > number1 % 10) ? (int)(number1 / 10) : (int)(number1 % 10));
}

void Variant3() // Способ 3
{
    Console.WriteLine("Способ 3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    char[] digitChar = number.ToString().ToCharArray();
    Console.WriteLine(((int)digitChar[0]>(int)digitChar[1]) ? digitChar[0]:digitChar[1]);
}

//Variant1();
//Variant2();
Variant3();
