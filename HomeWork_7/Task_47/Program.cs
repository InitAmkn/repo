/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GenerationRandomMatrix(int x, int y) //Генерация рандомного массива
{
    double[,] matrix1 = new double[x, y];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
        }
    }
    return matrix1;
}

void PrintMatrix<T>(T[,] matrix) //Вывод двумерного массива (матрицы) в консоль
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

double[,] arr = GenerationRandomMatrix(10, 5);
Console.WriteLine("Матрица заполненная случайными вещественными числами:");
PrintMatrix(arr);
