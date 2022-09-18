/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintMatrix1D<T>(T[] matrix) //Вывод одномерного массива (матрицы) в консоль
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]} ");
    }
}

double[] ArithmeticMeanColumns(int[,] mas)
{
    double[] arithmeticMean = new double[mas.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            sum = sum + mas[i, j];
        }
        arithmeticMean[j] = Math.Round(sum / mas.GetLength(0), 2);
        sum = 0;
    }
    return arithmeticMean;
}



int[,] arr = GenerationRandomMatrix(3, 10);
PrintMatrix2D(arr);

Console.WriteLine();
PrintMatrix1D(ArithmeticMeanColumns(arr));
