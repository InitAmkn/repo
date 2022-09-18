
int[]masMatrix1 = {0};
int[]masMatrix2 = {0};

Console.WriteLine("Введите матрицу 1 :");
Console.WriteLine("Пример ввода: a1,b1,c1");
string? matrix1 = Console.ReadLine();
Console.WriteLine("Введите матрицу 2 :");
Console.WriteLine("Пример ввода: a2,b2,c2");
string? matrix2 = Console.ReadLine();

if(matrix1!=null && matrix2!=null) 
    {
        masMatrix1 = InputMas(matrix1, ',');
        masMatrix2 = InputMas(matrix2, ',');
 
    }       
        printMas(masMatrix1);
        Console.WriteLine();
        printMas(masMatrix2);
        Console.WriteLine();

        printMas(sumMas(masMatrix1, masMatrix2));


int [] sumMas(int[]mas1,int[]mas2)
{   
    int [] mas3 = new int [mas1.Length] ;
    
    for(int i = 0; i < mas3.Length; i++)
        {
            mas3[i] = mas1[i] + mas2[i];
        }
    
    return mas3;
}


int [] InputMas(string matrix, char separator)   {
    string value = "";
    int[]mas = new int [matrix.Length];
    int j = 0;
    for(int i = 0; i < matrix.Length; i++)
        {

            if(matrix[i]!= separator)
            {
                value = value + matrix[i];
            }
            if(matrix[i] == separator || i == matrix.Length-1)
            {
                mas[j] = Convert.ToInt32(value);
                j++;
                 value = "";
            }
        }
      
        return ResizeArray(mas, j); 
    }

int[] ResizeArray(int[] masInput, int count)
        {
            int[] masOutput =new int [count];
        for(int i =0; i < count; i++)
        {
            masOutput[i] = masInput[i];
        }
                return masOutput;
        }

 void printMas(int[]masX)
 {
    for(int i = 0; i<masX.Length; i++)
    {
        Console.Write($"{masX[i]} ");
    }
   
 }


