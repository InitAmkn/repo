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
int spreadNumbers<T>(T[] mas)
{
    int outNumber = 0;
    return outNumber;
}

double[] arr = randMas(10, 0, 100);
Console.WriteLine($"Рандомный массив: {ArrayToString(arr)}");