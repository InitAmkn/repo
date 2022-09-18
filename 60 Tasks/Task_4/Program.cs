
        //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        //Усложнил задачу, добавил возможность добавлять любое кол-во чисел.

         double maxvalue1;
         string? wantEnterMore;
         //нашел ответ как решить проблему с ошибкой в интернете 
         //Ошибка (23 строка) - Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
         //https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/nullable-value-types

         Console.WriteLine("Введите первое число:"); //Не допускается ввод других символов кроме цифр
         double value1 = Convert.ToDouble(Console.ReadLine());
         maxvalue1 = value1;
        
        do{
        Console.WriteLine("################################################");
        Console.WriteLine("Хотите продолжить ввод чисел? Введите да / нет:");
        Console.WriteLine("нет - Вывести максимальное число из введеных ранее;");
        Console.WriteLine("да - Ввод нового числа."); 
        Console.WriteLine("################################################");
        wantEnterMore =  Console.ReadLine(); //Не допускается ввод других значений кроме да/нет
        
        if(wantEnterMore == "да")
        {
            Console.WriteLine("Введите число:");
            value1 = Convert.ToDouble(Console.ReadLine());
            if(value1>maxvalue1) maxvalue1 = value1;
        }
       
        }
       while(wantEnterMore == "да");
   
        if(wantEnterMore == "нет")
        {
            Console.WriteLine($"Максимальное число: {maxvalue1}"); 
        }

