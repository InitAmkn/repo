//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

 Console.WriteLine("Введите число:"); //Не допускается ввод других символов кроме цифр
    double value1 = Convert.ToDouble(Console.ReadLine());

    if(value1>0)
        { 
            Console.WriteLine("Четные числа:"); 
            for(int i = 2;i<=value1;i=i+2)
                {
                    Console.Write($"{i} ");
                }
        }
    if(value1<0)
        {
             Console.WriteLine("Четные числа:"); 
            for(int i = -2;i>=value1;i=i-2)
                {
                     Console.Write($"{i} ");
                }
        }
    if(value1==0)
        {
            Console.WriteLine("Вы ввели 0");
        }