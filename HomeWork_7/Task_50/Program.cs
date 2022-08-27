/*
Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет
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
string FindElementMatrix(int[,] mas, int x, int y)
{
    if (x < mas.GetLength(0) && y < mas.GetLength(1))
        return Convert.ToString(mas[x, y]);
    else return "такого числа в массиве нет";
}


int[,] arr = GenerationRandomMatrix(5, 5);
PrintMatrix(arr);

Console.WriteLine();

Console.WriteLine(FindElementMatrix(arr, 4, 2));




