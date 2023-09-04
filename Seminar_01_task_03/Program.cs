/* Задача №3
Напишите программу, которая будет выдавать
название дня недели по заданному номеру. */

/*// Первый вариант решения
int day = int.Parse(Console.ReadLine)??"0";

string [] dayOfWeek = new string[7];

dayOfWeek[0]="Понедельник";
dayOfWeek[1]="Вторник";
dayOfWeek[2]="Среда";
dayOfWeek[3]="Четверг";
dayOfWeek[4]="Пятница";
dayOfWeek[5]="Суббота";
dayOfWeek[6]="Воскресенье";

Console.WriteLine(dayOfWeek[day-1]); */

// Второй метод решения
/*
System.Console.WriteLine("Введите номер");
int a = Convert.ToInt32 (Console.ReadLine());
switch (a)
{
   case 1: Console.WriteLine ("Пн");
   break;

   case 2: Console.WriteLine ("Вт");
   break;

   case 3: Console.WriteLine ("Ср");
   break;

   case 4: Console.WriteLine ("Чт");
   break;

   case 5: Console.WriteLine ("Пт");
   break;

   case 6: Console.WriteLine ("Сб");
   break;

   case 7: Console.WriteLine ("Вс");
   break;
}*/

// Третий метод решения
/* string day = Console.ReadLine()??"0";

switch (day)
{
    case "1": Console.WriteLine("Понедельник"); break;
    case "2": Console.WriteLine("Вторник"); break;
    case "3": Console.WriteLine("Среда"); break;
    case "4": Console.WriteLine("Четверг"); break;
    case "5": Console.WriteLine("Пятница"); break;
    case "6": Console.WriteLine("Суббота"); break;
    case "7": Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Неверные данные"); break;
}*/

// Обращение к операционной системе
int dayNum = int.Parse(Console.ReadLine());
string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));
Console.WriteLine (outDayOfWeek);