/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0)
25(0,1,0)
34(1,0,0)
41(1,1,0)
27(0,0,1)
90(0,1,1)
26(1,0,1)
55(1,1,1)
*/


int[,,] GenerationRandomMatrix3D(int x, int y, int z) //Генерация рандомного массива
{
    int[,,] array3 = new int[x, y, z];
    int[] randArray = GenerationArrayRandomNonRepeatingNumbers(array3.Length);
    int count = 0;
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            for (int k = 0; k < array3.GetLength(2); k++)
            {
                array3[i, j, k] = randArray[count];
                count++;
            }
        }
    }
    return array3;
}

int[] GenerationArrayRandomNonRepeatingNumbers(int count)
{
    int[] outArray = new int[count];
    for (int i = 0; i < outArray.Length; i++)
    {
        int temp = 0;
        bool canAdd = true;
        do
        {
            canAdd = true;
            temp = new Random().Next(10, 100);
            for (int j = 0; j < i; j++)
            {
                if (temp == outArray[j]) canAdd = false;
            }

        } while (!canAdd);

        if (canAdd) outArray[i] = temp;
    }
    return outArray;
}

void PrintMatrix3D<T>(T[,,] matrix) //Вывод двумерного массива (матрицы) в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.WriteLine($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
        }
        // Console.WriteLine();
    }
}



Console.WriteLine();
int[,,] array = GenerationRandomMatrix3D(2, 2, 2);
PrintMatrix3D(array);
