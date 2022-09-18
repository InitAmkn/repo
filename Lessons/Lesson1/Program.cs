internal class Program
{
    private static void Main(string[] args)
    {
       Console.WriteLine("start task0:");
        task0();
        Console.WriteLine("end task0");

        Console.WriteLine("start task1:");
        task1();
        Console.WriteLine("end task1");

        Console.WriteLine("start task2:");
        task2();
        Console.WriteLine("end task2");

        Console.WriteLine("start task3:");
        task3();
        Console.WriteLine("end task3");

        Console.WriteLine("start task4:");
        task4();
        Console.WriteLine("end task4");


        void task0()
        {       
                
                Console.WriteLine("Input value:");
                int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(value*value);   
        }
        void task1()//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
        {
                bool isMultiplication;
                Console.WriteLine("Input first value:");
                int value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input second value:");
                int value2 = Convert.ToInt32(Console.ReadLine());
                if(value2 == value1/value2)
                {isMultiplication = true;}
                else
                {
                    isMultiplication = false;
                }

                Console.WriteLine(isMultiplication);

        }
        void task2()//2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
        {
            string[] week= {"","понедельник", "вторник","среда","четверг", "пятница", "суббота","воскресенье" };
               Console.WriteLine("Input value:");
                int value1 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine(week[value1]);
        }
        void task3()//3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
        {
             Console.WriteLine("Input first value:");
                int value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input second value:");
                int value2 = Convert.ToInt32(Console.ReadLine());
               int i=0;
               if(value1<value2)
                {
                    i=value1;
                    
                    while(i<value2)
                    {
                     Console.Write($"{i} ");
                    i++;
                    }
                }

                if(value1>value2)
                {
                    i=value2;
                    while(i<value1)
                    {
                     Console.Write($"{i} ");
                      i++;
                    }
                }
                Console.Write(i);
            }
        void task4()//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
        {
            Console.WriteLine("Input first value:");
                int value1 = Convert.ToInt32(Console.ReadLine());
                int outputValue = value1 % 10;
                Console.Write(outputValue);
        }
        

    }

}