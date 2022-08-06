//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
  
  Console.WriteLine("Введите число:"); //Не допускается ввод других символов кроме цифр
    double value1 = Convert.ToDouble(Console.ReadLine());
    
     if(value1 == 0)
    {
        Console.WriteLine("Вы ввели 0");
        
    } else if(value1 % 2 == 0)
    {
        Console.WriteLine("Число четное");
    } else
    {
         Console.WriteLine("Число нечетное");
    }