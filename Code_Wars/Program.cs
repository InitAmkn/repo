using System;
using System.Collections.Generic;




class Program
{

    static void Main(string[] args)
    {
        int[,] arr = library.GenerationRandomMatrix(10, 10);

        library.PrintMatrix(arr);


        Console.WriteLine(library.FindDeterminant(arr));
    }
}
