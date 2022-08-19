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
    public static void printMas(int[] masX)// Вывод массива в консоль
    {
        for (int i = 0; i < masX.Length; i++)
        {
            Console.Write($"{masX[i]} ");
        }

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
    public static string[] Solution(string str) //разбиение строки на массив 
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
}

