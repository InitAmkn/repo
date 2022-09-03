/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

OutputNaturalNumbers(-7, 2);


void OutputNaturalNumbers(int m, int n)
{
    if (m == n) Console.Write($"{n} ");
    if (m > n)
    {
        Console.Write($"{n} ");
        n++;
        OutputNaturalNumbers(m, n);
    }
    if (m < n)
    {
        Console.Write($"{m} ");
        m++;
        OutputNaturalNumbers(m, n);
    }

}

