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
        int[] c = new int[a.Length + b.Length];
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
    public static int[] ResizeArray(int[] masInput, int count)//изменение размера массива
    {
        int[] masOutput = new int[count];
        for (int i = 0; i < count; i++)
        {
            masOutput[i] = masInput[i];
        }
        return masOutput;
    }
    public static bool Narcissistic(int value) //Проверка на нарциссическое число
    {
        bool isNarcissistic = false;
        int intChar = 0;
        int sumDegree = 0;
        int valueTemp = value;
        int powChar;
        for (int i = 0; i < charCounter(value); i++)
        {
            if (valueTemp > 9) intChar = valueTemp % (valueTemp / 10 * 10);
            else intChar = valueTemp;
            powChar = intChar;
            for (int j = 1; j < charCounter(value); j++)
            {
                powChar = powChar * intChar;
            }
            sumDegree = sumDegree + powChar;
            valueTemp = valueTemp / 10;
        }


        if (value == sumDegree) isNarcissistic = true;

        return isNarcissistic;
    }
    public static int charCounter(int value) //метод подсчета кол-ва цифр в числе
    {
        int countDecimal = 1;
        int countChar = 0;
        int divisionResult = 0;
        do
        {
            divisionResult = value / countDecimal;
            countDecimal = countDecimal * 10;
            countChar++;
        } while (divisionResult != 0);

        return countChar - 1;
    }
    public static string[] Solution(string str) //разбиение строки на массив по 2 символа
    {
        /*
         * Complete the solution so that it splits the string into pairs of two characters. 
        If the string contains an odd number of characters then it should replace the 
       missing second character of the final pair with an underscore('_').
        Examples:
         *'abc' =>  ['ab', 'c_']
         *'abcdef' => ['ab', 'cd', 'ef']*
         */
        if (str.Length % 2 != 0)
        {
            str = str + "_";
        }
        string[] outPut = new string[str.Length / 2];
        int count = 0;
        for (int i = 0; i < str.Length - 1; i = i + 2)
        {
            string word = "";
            word = word + str[i];
            word = word + str[i + 1];
            outPut[count] = word;
            count++;
        }
        return outPut;
    }
    public static string GetReadableTime(int seconds) //пересчет секунд в часы
    {
        /*Write a function, which takes a non-negative integer(seconds) as input and returns the time in a human-readable format(HH: MM:SS)
            HH = hours, padded to 2 digits, range: 00 - 99
            MM = minutes, padded to 2 digits, range: 00 - 59
            SS = seconds, padded to 2 digits, range: 00 - 59
            The maximum time never exceeds 359999(99:59:59)
         You can find some examples in the test fixtures.*/

        int HH = 0;
        int MM = 0;
        int SS = 0;

        SS = seconds % 60;
        MM = seconds / 60 % 60;
        HH = seconds / 60 / 60;

        string sHH = "" + HH;
        string sMM = "" + MM;
        string sSS = "" + SS;

        if (HH < 10) sHH = "0" + HH;
        if (MM < 10) sMM = "0" + MM;
        if (SS < 10) sSS = "0" + SS;

        string outPut = "" + sHH + ":" + sMM + ":" + sSS;
        return outPut;
    }
    public static string Rot13(string input)
    {
        /*
           How can you tell an extrovert from an introvert at NSA? 
           Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.
           I found this joke on USENET, but the punchline is scrambled.
           Maybe you can decipher it? According to Wikipedia, ROT13 
           (http://en.wikipedia.org/wiki/ROT13) is frequently used to obfuscate 
           jokes on USENET.
           Hint: For this task you're only supposed to substitue characters. 
           Not spaces, punctuation, numbers etc.
           Test examples:
           "EBG13 rknzcyr." -->
           "ROT13 example."
           "This is my first ROT13 excercise!" -->
           "Guvf vf zl svefg EBG13 rkprepvfr!"
           */
        const string alphabetLow = "abcdefghijklmnopqrstuvwxyz";
        const string alphabetHigh = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char symbol;
        string outPut1 = "";
        for (int i = 0; i < input.Length; i++)
        {
            symbol = FindCheck(alphabetHigh, input[i]);
            symbol = FindCheck(alphabetLow, symbol);
            outPut1 = outPut1 + symbol;
        }
        return outPut1;

        char FindCheck(string abc, char s)
        {
            char output = s;
            for (int j = 0; j < abc.Length; j++)
            {
                if (s == abc[j])
                {
                    if ((j + 13) <= abc.Length - 1)
                    {
                        output = abc[j + 13];
                    }
                    if ((j + 13) > abc.Length - 1)
                    {
                        output = abc[j + 13 - (abc.Length)];
                    }
                }
            }
            return output;
        }

    }
    public static int FindDeterminant(int[,] matrix) //вычисление детерминанта матрицы
    {
        int det = 0;
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        if (matrix.GetLength(0) > 2 && matrix.GetLength(1) > 2)
        {
            int sign = -1;
            for (int i = 1; i <= matrix.GetLength(1); i++)
            {
                if (i % 2 == 0)
                {
                    sign = -1;
                }
                if (i % 2 != 0)
                {
                    sign = 1;
                }
                det = det + matrix[0, i - 1] * FindDeterminant(DeleteElementMatrix(matrix, 0, i - 1)) * sign;
            }
            return det;
        }
        if (matrix.GetLength(0) == 1 && matrix.GetLength(1) == 1)
        {
            det = matrix[0, 0];
        }
        return det;
    }
    public static int FindDeterminant(int[][] matrix) //вычисление детерминанта матрицы
    {
        int det = 0;
        if (matrix.Length == 2)
        {
            det = matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
        }
        if (matrix.Length > 2)
        {
            int sign = -1;
            for (int i = 1; i <= matrix.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sign = -1;
                }
                if (i % 2 != 0)
                {
                    sign = 1;
                }
                det = det + matrix[0][i - 1] * FindDeterminant(DeleteElementMatrix(matrix, 0, i - 1)) * sign;
            }
            return det;
        }
        if (matrix.Length == 1)
        {
            det = matrix[0][0];
        }
        return det;
    }
    public static int[][] DeleteElementMatrix(int[][] matrix, int indexI, int indexJ) //Удаление элемента массива по индексу
    {
        int[][] outputMas = new int[matrix.Length - 1][];
        for (int i = 0; i < outputMas.Length; i++)
        {
            outputMas[i] = new int[matrix[i].Length - 1];
        }
        int iOld = 0, jOld = 0;

        for (int i = 0; i < outputMas.Length; i++)
        {
            if (i == indexI) iOld = 1;
            for (int j = 0; j < outputMas[i].Length; j++)
            {
                if (j == indexJ) jOld = 1;
                outputMas[i][j] = matrix[i + iOld][j + jOld];
            }
            jOld = 0;
        }
        return outputMas;
    }
    public static int[,] DeleteElementMatrix(int[,] matrix, int indexI, int indexJ) //Удаление элемента массива по индексу
    {
        int[,] outputMas = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

        int iOld = 0, jOld = 0;

        for (int i = 0; i < outputMas.GetLength(0); i++)
        {
            if (i == indexI) iOld = 1;
            for (int j = 0; j < outputMas.GetLength(1); j++)
            {
                if (j == indexJ) jOld = 1;
                outputMas[i, j] = matrix[i + iOld, j + jOld];
            }
            jOld = 0;
        }
        return outputMas;
    }
    public static int[][] GenerationRandomMatrix1(int x, int y) //Генерация рандомного массива
    {
        int[][] matrix = new int[x][];
        for (int i = 0; i < y; i++)
        {
            matrix[i] = new int[y];
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = new Random().Next(0, 10);
            }
        }
        return matrix;
    }
    public static void PrintMatrix2D<T>(T[][] matrix) //Вывод двумерного массива (матрицы) в консоль
    {

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write($"{matrix[i][j]} ");
            }
            Console.WriteLine();
        }
    }
    public static int[,] GenerationRandomMatrix(int x, int y) //Генерация рандомного массива
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
    public static void PrintMatrix2D<T>(T[,] matrix) //Вывод двумерного массива (матрицы) в консоль
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
    public static void PrintMatrix1D<T>(T[] matrix) //Вывод двумерного массива (матрицы) в консоль
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write($"{matrix[i]} ");
        }
    }
    public static int[,] TurnMatrixClockwise(int[,] matrix) //Поворот матрицы по часовой
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
    public static int[,] TurnMatrixAnticlockwise(int[,] matrix) //Поворот матрицы против часовой
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
    public static List<string> Top3(string s) //Most frequently used words in a text
    {
        const string alphabet = " ,_/.&?;:><[]{}()";
        string word = "";
        List<string> masString = new List<string>();
        for (int i = 0; i < s.Length; i++)
        {
            bool canAdd = true;
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (s[i] == alphabet[j])
                {
                    canAdd = false;
                }
            }
            if (canAdd)
            {
                word = word + s[i];
            }
            if (!canAdd || i == s.Length - 1)
            {
                if (word != "")
                {
                    masString.Add(word);
                    word = "";
                }
            }

        }
        masString.Sort();
        string countWord = masString[0];
        int count = -1;
        int tempCount = 0;

        List<string> masStringTop3 = new List<string>();
        int[] indexTop = new int[masString.Count];
        //int[][] result = new int[][];

        for (int i = 0; i < masString.Count; i++)
        {
            if (countWord == masString[i])
            {
                count++;
            }

            if (countWord != masString[i] || i == masString.Count - 1)
            {
                countWord = masString[i];
                tempCount = count;

                if (i != masString.Count - 1) count = 0;
            }
            indexTop[i] = count;
        }


        return masStringTop3;
    }
}

