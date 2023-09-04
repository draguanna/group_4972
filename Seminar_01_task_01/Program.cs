/* Задача №1
Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
*/
Console.Clear();
Console.WriteLine ("Введите число A: ");
int firstNum = int.Parse(Console.ReadLine()??"0");

Console.WriteLine ("Введите число B: ");
int secondNum = int.Parse(Console.ReadLine()??"0");


// Тернарный оператор
Console.WriteLine(firstNum == Math.Pow(secondNum, 2) ? "Да" : "Нет");

/*//Экваивалентно записи
if (firstNum  == Math.Pow(secondNum,2)) 
  {Console.WriteLine("Да");}
else
{Console.WriteLine("Нет");}*/