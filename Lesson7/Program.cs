// поворот матриц

int[,] GenerationRandomMatrix(int x, int y)
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
void PrintMatrix<T>(T[,] matrix)
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
int[,] TurnMatrixClockwise(int[,] matrix)
{
    int[,] outMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < outMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < outMatrix.GetLength(1); j++)
        {
            outMatrix[i, j] = matrix[outMatrix.GetLength(1) - j - 1, i];
        }
    }
    return outMatrix;
}

int[,] TurnMatrixAnticlockwise(int[,] matrix)
{
    int[,] outMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < outMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < outMatrix.GetLength(1); j++)
        {
            outMatrix[i, j] = matrix[j, outMatrix.GetLength(0) - i - 1];
        }
    }
    return outMatrix;
}

int[,] matrix = GenerationRandomMatrix(4, 3);

PrintMatrix(matrix);
Console.WriteLine("перевернутая матрица по часовой:");
PrintMatrix(TurnMatrixClockwise(matrix));
Console.WriteLine("перевернутая матрица против часовой:");
PrintMatrix(TurnMatrixAnticlockwise(TurnMatrixClockwise(matrix)));