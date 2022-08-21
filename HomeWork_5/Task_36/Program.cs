/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] randMas(int quantity, int minValueRand, int maxValueRand)
{
    int[] mas = new int[quantity];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(minValueRand, maxValueRand);
    }
    return mas;
}

string ArrayToString(int[] col)
{
    return $"[{String.Join(' ', col)}]";
}

int evenIndexNumbersAdder(int[] inputMas)
{
    int sum = 0;
    for (int i = 0; i < inputMas.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + inputMas[i];
        }
    }
    return sum;
}

int[] arr = randMas(10, 100, 1000);
Console.WriteLine($"Рандомный массив: {ArrayToString(arr)}");
Console.WriteLine($"Кол-во четных чисел: {evenIndexNumbersAdder(arr)}");