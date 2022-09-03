/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/


long AckermanFunction(long m, long n, long A = 0)
{
    if (m > 0 && n > 0) A = AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    if (m > 0 && n == 0) A = AckermanFunction(m - 1, 1);
    if (m == 0) A = n + 1;
    return A;
}

Console.WriteLine(AckermanFunction(3, 10));