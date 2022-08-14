using System;


  

class library
{
  
    public static int[] MoveZeroes(int[] arr) // перемещение нулей в конец массива
        {
            int[] arr1 = new int[arr.Length];
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {

                if (arr[i] != 0)
                {
                    arr1[index] = arr[i];
                    index++;

                  }
            }
            return arr1;
        }
    public static int[] ArrayDiff(int[] a, int[] b) //Вычитание элементов массива b из a
        {
            /*Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
            It should remove all values from list a, which are present in list b keeping their order.*/
            int[] c = new int[a.Length+b.Length];
            int count = 0;
            
            for (int i = 0; i < a.Length; i++)
            {
                bool canAdd = true;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j]) canAdd = false;
                    if (a[i] != b[j] && canAdd) canAdd = true;

                }
                if (canAdd)
                {
                    c[count] = a[i];
                    count++;
                }
            }

            int[] outPut = new int[count];
            for (int i = 0; i < outPut.Length; i++)
                {
                outPut[i] = c[i];
                }
            return outPut;
        }
    public static int[] InputMas(string matrix, char separator) //Считывание массива из строки
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
    public static void printMas(int[] masX)// Вывод массива в консоль
    {
        for (int i = 0; i < masX.Length; i++)
        {
            Console.Write($"{masX[i]} ");
        }

    }
    public static int[] ResizeArray(int[] masInput, int count)//изменение размера массива
    {
        int[] masOutput = new int[count];
        for (int i = 0; i < count; i++)
        {
            masOutput[i] = masInput[i];
        }
        return masOutput;
    }
 }
       
