using System;
using System.Collections.Generic;




class Program
{

    static void Main(string[] args)
    {

        //Console.WriteLine(library.Rot13("This is my first ROT13 excercise!"));
        //Console.WriteLine(library.Rot13("AaSs"));

        int[,] a = {
{1,1,2,3,4},
{5,6,7,8,9},
{1,1,2,5,4},
{5,8,7,8,1},
{5,8,7,8,1}
};
        print(a);
        Console.WriteLine();

        print(DelElementMatrix(a));

        int[,] DelElementMatrix(int[,] mas)
        {
            int[,] masMin = new int[mas.GetLength(0) - 1, mas.GetLength(1) - 1];

            int iOld = 0, jOld = 0;

            for (int i = 0; i < masMin.GetLength(0); i++)
            {
                if (i == 3) iOld = 1;
                for (int j = 0; j < masMin.GetLength(1); j++)
                {
                    if (j == 1) jOld = 1;
                    masMin[i, j] = mas[i + iOld, j + jOld];

                }
                iOld = 0;
                jOld = 0;
            }

            return masMin;
        }

        void print(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
        }

    }


}
