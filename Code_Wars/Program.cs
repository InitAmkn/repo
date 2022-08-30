using System;
using System.Collections.Generic;




class Program
{

    static void Main(string[] args)
    {
        //int[,] arr = library.GenerationRandomMatrix(10, 10);
        //library.PrintMatrix(arr);
        // Console.WriteLine(library.FindDeterminant(arr));
        int[][] arr1 = library.GenerationRandomMatrix1(10, 10);
        library.PrintMatrix(arr1);
        Console.WriteLine(library.FindDeterminant(arr1));
    }
}
