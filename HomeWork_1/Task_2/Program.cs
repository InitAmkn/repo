internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
         double maxvalue1;
         string checkAnswer;

         Console.WriteLine("Введите первое число:"); //Не допускается ввод других символов кроме цифр
         double value1 = Convert.ToDouble(Console.ReadLine());
         maxvalue1 = value1;
        
        do{
        Console.WriteLine("################################################");
        Console.WriteLine("Хотите продолжить ввод чисел? Введите да / нет:");
        Console.WriteLine("нет - Вывести максимальное число из введеных ранее;");
        Console.WriteLine("да - Ввод нового числа."); 
        Console.WriteLine("################################################");
        checkAnswer =  Console.ReadLine();
        
        if(checkAnswer == "да")
        {
            Console.WriteLine("Введите число:");
            value1 = Convert.ToDouble(Console.ReadLine());
            if(value1>maxvalue1) maxvalue1 = value1;
        }
       
        }
       while(checkAnswer == "да");
   
        if(checkAnswer == "нет")
        {
            Console.WriteLine($"Максимальное число: {maxvalue1}"); 
        }



    }
}