//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

        
        Console.WriteLine("Input first value:"); //Не допускается ввод других символов кроме цифр
        double value1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input second value:"); //Не допускается ввод других символов кроме цифр
        double value2 = Convert.ToDouble(Console.ReadLine());

        if(value1>value2)   Console.WriteLine($"MaxValue: {value1}");
        if(value1<value2)   Console.WriteLine($"MaxValue: {value2}");
        if(value1==value2)  Console.WriteLine($"{value1} = {value2}");
