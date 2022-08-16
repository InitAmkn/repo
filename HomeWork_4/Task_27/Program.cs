
/*  Задача 27: Напишите матод, который принимает на вход число и выдаёт сумму 
цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(sumDigits(2525424));

        int sumDigits(int number)
        {
            int outputSum = 0;
            while (number != 0)
            {
                outputSum = outputSum + number % 10;
                number = number / 10;
            }
            return outputSum;
        }
    }
}