using System;
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] randMas(int quantity, int minValueRand, int maxValueRand)
{
    double[] mas = new double[quantity];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(minValueRand, maxValueRand - 1) + new Random().NextDouble();
    }
    return mas;
}

string ArrayToString<T>(T[] col)
{
    return $"[{String.Join(' ', col)}]";
}

double FindMax(double[] mas)
{
    if (mas == null) return 0;
    double max = mas[0];
    for (int i = 0; i < mas.Length; i++)
    {
        if (max < mas[i])
        {
            max = mas[i];
        }
    }
    return max;
}

double FindMin(double[] mas)
{
    if (mas == null) return 0;
    double min = mas[0];
    for (int i = 0; i < mas.Length; i++)
    {
        if (min > mas[i])
        {
            min = mas[i];
        }
    }
    return min;
}
double spreadNumbers(double[] mas)
{
    double outNumber = 0;
    outNumber = FindMax(mas) - FindMin(mas);
    return outNumber;
}

double[] arr = randMas(10, 0, 100);
Console.WriteLine($"Рандомный массив: {ArrayToString(arr)}");
Console.WriteLine($"Разброс элементов массива: {spreadNumbers(arr)}");