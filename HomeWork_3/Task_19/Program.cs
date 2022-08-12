/*
Задача 19
Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
строки использовать нельзя
*/

palindromeСheck(123456);

int charCounter(int value) //метод подсчета кол-ва цифр в числе
    {
        int countDecimal = 1;
        int countChar = 0;
        int divisionResult = 0;
       do
        {
            divisionResult = value/countDecimal;
            countDecimal = countDecimal * 10;
            countChar++;
        } while(divisionResult!=0);

        return countChar;
    }

   void palindromeСheck(int value)
    {
        int countChar = charCounter(value);
        int countDecimalMin = 1;
        int countDecimalMax = 1;
        int value1,value2;
        bool IsPalindrome = true;

        for(int j = 1; j<countChar-1; j++)
        {
           countDecimalMax = countDecimalMax * 10;
        }
        for(int i = 0; i< countChar/2;i++)
        {
            value1 = value/countDecimalMax % 10;
            value2 = value % (countDecimalMin*10)/countDecimalMin;
        
            if(value1!=value2 && IsPalindrome) IsPalindrome = false;

            countDecimalMin = countDecimalMin * 10;
            countDecimalMax = countDecimalMax / 10;
        }
        if(IsPalindrome) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }