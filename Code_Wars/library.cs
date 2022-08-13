using System;


  

class library
{
  
     public static int[] MoveZeroes(int[] arr) // перемещение нулей в конец массива
        {
            int[] arr1 = new int[arr.Length];
            int j = 0;

            for (int i = 0; i < arr1.Length; i++)
            {

                if (arr[i] != 0)
                {
                    arr1[j] = arr[i];
                    j++;

                  }
            }
            return arr1;
        }

 }
       
