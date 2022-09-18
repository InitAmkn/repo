
//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


internal partial class Program
{
    private static void Main(string[] args)
    {
        int value1 = Convert.ToInt32(Console.ReadLine());
        int value2 = Convert.ToInt32(Console.ReadLine());

        remainderDivision(value1, value2);

        void remainderDivision(int v1, int v2)
        {
            if (v1 % v2 == 0)
            {
                Console.WriteLine("Кратно");
            }
            else
            {
                Console.WriteLine($"не кратно, остаток {v1 % v2}");
            }
             }
         }
}