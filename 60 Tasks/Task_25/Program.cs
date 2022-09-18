/* Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
нельзя использовать pow
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(myPow(2, 4));

        int myPow(int number, int degree)
        {
            int result = 1;

            for (int i = 0; i < degree; i++)
            {
                result = result * number;
            }
            return result;

        }
    }
}