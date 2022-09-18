
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] randMas(int quantity, int minValueRand, int maxValueRand)
{
    int[] mas = new int[quantity];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(minValueRand, maxValueRand + 1);
    }
    return mas;
}

string ArrayToString(int[] col)
{
    return $"[{String.Join(' ', col)}]";
}

int evenNumbersCounter(int[] inputMas)
{
    int count = 0;
    for (int i = 0; i < inputMas.Length; i++)
    {
        if (inputMas[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] arr = randMas(10, 100, 999);
Console.WriteLine($"Рандомный массив: {ArrayToString(arr)}");
Console.WriteLine($"Кол-во четных чисел: {evenNumbersCounter(arr)}");