namespace System;

public static class library
{
   public static int[] InputMas(string matrix, char separator)
    {
        string value = "";
        int[] mas = new int[matrix.Length];
        int j = 0;
        for (int i = 0; i < matrix.Length; i++)
        {

            if (matrix[i] != separator)
            {
                value = value + matrix[i];
            }
            if (matrix[i] == separator || i == matrix.Length - 1)
            {
                mas[j] = Convert.ToInt32(value);
                j++;
                value = "";
            }
        }

        return ResizeArray(mas, j);
    }

   public static void printMas(int[] masX)
    {
        for (int i = 0; i < masX.Length; i++)
        {
            Console.Write($"{masX[i]} ");
        }

    }

   public static int[] ResizeArray(int[] masInput, int count)
    {
        int[] masOutput = new int[count];
        for (int i = 0; i < count; i++)
        {
            masOutput[i] = masInput[i];
        }
        return masOutput;
    }
}


