
int[,] findCat =
{
{1,1,1,1,1,1,1,1,1,1,1},
{1,0,0,1,0,0,0,0,0,0,1},
{1,0,0,0,1,1,0,0,2,0,1},
{1,0,0,0,0,0,1,0,0,0,1},
{1,0,0,0,0,0,0,0,0,0,1},
{1,0,1,0,0,0,0,0,0,0,1},
{1,0,0,1,0,1,0,0,0,0,1},
{1,0,0,0,0,0,1,0,0,0,1},
{1,0,3,0,1,0,0,0,0,0,1},
{1,1,1,1,1,1,1,1,1,1,1},
};

PrintMatrix2DBeautifully(findCat);
PrintMatrix2DBeautifully(Movement(findCat, 8, 2).Item1);



static void PrintMatrix2DBeautifully(int[,] matrix) //Вывод двумерного массива (матрицы) в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) Console.Write("  ");
            if (matrix[i, j] == 1) Console.Write("х ");
            if (matrix[i, j] == 2) Console.Write("К ");
            if (matrix[i, j] == 3) Console.Write("В ");
            if (matrix[i, j] == 4) Console.Write("- ");
        }
        Console.WriteLine();
    }
}

(int[,], int, int) Movement(int[,] matrix, int x, int y)
{

    if (matrix[x, y] != 2)
    {
        if (matrix[x - 1, y] != 1)
        {
            matrix[x - 1, y] = 4;
            matrix[x, y] = 3;
            x--;
            Movement(matrix, x, y);
        }
        if (matrix[x + 1, y] != 1)
        {
            matrix[x + 1, y] = 4;
            matrix[x, y] = 3;
            x++;
            Movement(matrix, x, y);
        }
        if (matrix[x, y - 1] != 1)
        {
            matrix[x, y - 1] = 4;
            matrix[x, y] = 3;
            y--;
            Movement(matrix, x, y);
        }
        if (matrix[x, y + 1] != 1)
        {
            matrix[x, y + 1] = 4;
            matrix[x, y] = 3;
            y++;
            Movement(matrix, x, y);
        }
    }

    return (matrix, x, y);
}

