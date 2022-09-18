/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int[,] SortStringsArray(int[,] arr) //сортировка строк массива
{
    int[,] outputArray = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < outputArray.GetLength(0); i++)
    {
        for (int j = 0; j < outputArray.GetLength(1); j++)
        {
            outputArray[i, j] = arr[i, j];
        }
    }
    for (int f = 0; f < outputArray.GetLength(0); f++)
    {
        int temp = arr[f, 0];
        for (int k = 0; k < outputArray.GetLength(1); k++)
        {
            for (int j = 0; j < outputArray.GetLength(1) - 1; j++)
            {
                if (outputArray[f, j + 1] > outputArray[f, j])
                {
                    temp = outputArray[f, j];
                    outputArray[f, j] = outputArray[f, j + 1];
                    outputArray[f, j + 1] = temp;
                }
            }
        }
    }
    return outputArray;
}



int[,] mas = GenerationRandomMatrix(5, 5);
PrintMatrix2D(mas);

Console.WriteLine();

PrintMatrix2D(SortStringsArray(mas));

Console.WriteLine();







