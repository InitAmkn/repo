
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int OutputSumNaturalNumbers(int m, int n, int sum = 0)
{
    if (m > n) sum = n + OutputSumNaturalNumbers(m, n + 1, sum);
    if (m < n) sum = m + OutputSumNaturalNumbers(m + 1, n, sum);
    if (m == n) sum = sum + m;
    return sum;
}

Console.WriteLine(OutputSumNaturalNumbers(1, 15));