//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 68                                     
//                                          Домашнее задание к семинару 09
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
Dictionary<(int, int), int> memoizationCache = new Dictionary<(int, int), int>();

// Ввод данных.
int m = ReadInt("Введите значение M: ");
int n = ReadInt("Введите значение N: ");

// Простой метод вычисления функции Аккермана.
Console.WriteLine($"[simple] Значение функции A({m},{n}) = {AckermannFunction(m, n)}");

// Использвоание мемоизации при вычислении функции Аккермана.
Console.WriteLine($"[memo] Значение функции A({m},{n}) = {AckermannFunctionMemo(m, n)}");

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вычисление функции Аккермана.
int AckermannFunction(int m, int n)
{
    if (m == 0) { return n + 1; }
    else if (m > 0 && n == 0) { return AckermannFunction(m - 1, 1); }
         else { return AckermannFunction(m - 1, AckermannFunction(m, n - 1)); }
}

// Вычисление функции Аккермана c использованием мемоизации.
int AckermannFunctionMemo(int m, int n)
{
    if (m == 0) { return n + 1; }
    else if (m > 0 && n == 0)
    {
     return memoizationCache.TryGetValue((m - 1, 1), out var cachedResult)
        ? cachedResult
        : AckermannFunction(m - 1, 1);
    }
        else
        {
            var key = (m, n);
            if (memoizationCache.TryGetValue(key, out var cachedResult)) 
               { return cachedResult; }
            else
            {
                var result = AckermannFunction(m - 1, AckermannFunction(m, n - 1));
                memoizationCache[key] = result;
                return result;
            }
        }
}