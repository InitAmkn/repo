
//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


int value1 = Convert.ToInt32(Console.ReadLine());
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 % value2 == 0)
{
    Console.WriteLine("Кратно");
}else 
{
        Console.WriteLine($"не кратно, остаток {value1 % value2}");
}