/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerationRandomMatrix(int x, int y) //Генерация рандомного массива
{
    int[,] matrix1 = new int[x, y];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix1;
}
void PrintMatrix2D<T>(T[,] matrix) //Вывод двумерного массива (матрицы) в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int StringWithMinSumElements(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int indexMinSum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] = sum[i] + matrix[i, j];
        }
    }
    int minSum = sum[0];

    for (int i = 1; i < sum.Length; i++)
    {
        if (minSum > sum[i])
        {
            minSum = sum[i];
            indexMinSum = i;
        }
    }
    return indexMinSum;
}

int[,] mas = GenerationRandomMatrix(3, 3);

PrintMatrix2D(mas);

Console.WriteLine();
Console.WriteLine(StringWithMinSumElements(mas));