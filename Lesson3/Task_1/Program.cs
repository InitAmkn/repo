Console.WriteLine("Введите матрицу 1 :");
Console.WriteLine("Пример ввода: a1,b1,c1");
string? matrix1 = Console.ReadLine();
Console.WriteLine("Введите матрицу 2 :");
Console.WriteLine("Пример ввода: a2,b2,c2");
string? matrix2 = Console.ReadLine();


printMas(InputMas(matrix1));
Console.WriteLine();
printMas(InputMas(matrix2));

int []


int [] InputMas(string matrix)   {

    int[]mas = new int [matrix.Length];
    string value = "";
    int j = 0;
    for(int i = 0; i < matrix.Length; i++)
        {

            if(matrix1[i]!= ',')
            {
                value = value + matrix[i];
            }
            if(matrix1[i] == ',' || i == matrix.Length-1)
            {
                mas[j] = Convert.ToInt32(value);
                j++;
                 value = "";
            }
        }
        Array.Resize(ref mas, j);
        return mas; 
    }

 void printMas(int[]mas)
 {
    for(int i = 0; i<mas.Count(); i++)
    {
        Console.Write($"{mas[i]} ");
    }
   
 }


