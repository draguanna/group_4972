/*
Задача №7
Напишите программу, которая принимает на вход
трёхзначное число и на выходе
показывает последнюю цифру этого числа.

*/

Console.Clear();

/*int num = int.Parse(Console.ReadLine()??"0");
if (num > 100 && num < 1000)
{
    int lastDigit = num%10;
    Console.WriteLine ("Последняя цифра числа {0} это {1}", num, lastDigit);
}
else 
{
    Console.WriteLine ("Число не трехзначное");
}*/

// Вариант с тернарным оператором

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num < 1000 && num > 99 ? num % 10 : "Число не трёхзначное");

