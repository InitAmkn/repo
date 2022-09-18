/*
int[] createRandom(int n = 12)
{
    return new int[n];
}




void Fill(int[] array, int min = -9, int max = 9)
{

    int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }


}*/

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
string ArrayToString(int[] col)
{
    return $"[{String.Join(' ', col)}]";
}

int[] randMas(int quantity, int minRand, int maxRand)
{
    int[] mas = new int[quantity];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(minRand, maxRand);
    }
    return mas;
}

int count(int[] mas)
{
    int outputCount = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] >= 10 & mas[i] <= 99) outputCount++;
    }
    return outputCount;
}



int[] mas = randMas(5, -10, 200);
Console.WriteLine(ArrayToString(mas));
Console.WriteLine(ArrayToString(PowPair(mas)));


Console.WriteLine(count(mas));

/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] PowPair(int[] mas)
{
    int[] outMas = new int[mas.Length / 2];
    if (mas.Length % 2 != 0)
    {
        outMas = new int[mas.Length / 2 + 1];
    }
    for (int i = 0; i < outMas.Length; i++)
    {
        if (i != mas.Length / 2) outMas[i] = mas[i] * mas[mas.Length - 1 - i];
        if (i == mas.Length / 2) outMas[i] = mas[i];
    }

    return outMas;
}