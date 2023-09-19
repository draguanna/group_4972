//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 25
//                                      Домашнее задание к семинару 04
//   Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//   * Написать калькулятор с операциями +, -, /, * и возведение в степень
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear(); // Очистка консоли

// Ввод выражения c клавиатуры
int numA = ReadInt("Введите число A: ");
char operation = ReadOperation("Введите оператор (+, -, *, /, ^): ");
int numB = ReadInt("Введите число B: ");

double result = Calculate(numA, numB, operation); // Вычисление результата
PrintResult($"{numA}{operation}{numB}={result}"); // Вывод результата на экран

//                                                    Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод числа с клавиатуры
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Ввод оператора с клавиатуры
char ReadOperation(string msg)
{
    Console.Write(msg);
    return char.Parse(Console.ReadLine() ?? "+"); 
}

// Вывод результата на экран
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Сумма
int Sum(int numA, int numB)
{
    int sum = numA + numB;
    return sum;
}

// Разность
int Subtraction(int numA, int numB)
{
    int sub = numA - numB;
    return sub;
}

// Деление
double Division(int numA, int numB)
{
    double div = (double)numA / numB;
    return div;
}

// Умножение 
int Multiplication(int numA, int numB)
{
    int mult = numA * numB;
    return mult;
}
// Возведение в степень
long Pow(int numA, int numB)
{
    long exp = 1;
    for (int i = 1; i <= numB; i++) { exp *= numA; }
    return exp;
}

// Вычисление результата
double Calculate(int numA, int numB, char operation)
{
    double result = 0;
    switch (operation)
    {
        case '+': result = Sum(numA, numB); break;
        case '-': result = Subtraction(numA, numB); break;
        case '/': result = Division(numA, numB); break;
        case '*': result = Multiplication(numA, numB); break;
        case '^': result = Pow(numA, numB); break;
        default: return 0;
    }
    return result;
}