/*
** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
    Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];


    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int tempMult = 0;

            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                tempMult = tempMult + matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = tempMult;
            tempMult = 0;

        }
    }

    return result;
}



int[,] matrix1 = GenerationRandomMatrix(2, 3);
int[,] matrix2 = GenerationRandomMatrix(3, 3);

PrintMatrix2D(matrix1);

PrintMatrix2D(matrix2);

PrintMatrix2D(MultiplicationMatrix(matrix1, matrix2));


