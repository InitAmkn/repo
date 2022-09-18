/*Задача 23

Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

 Console.Write("Введите число:");
 int value = Convert.ToInt32(Console.ReadLine());
 
    printMas(cubeTable(value));

 int [] cubeTable(int value)
    {
        int[]mas = new int [value];
        for(int i = 1; i<value+1; i++)
            {
                mas[i-1] = i*i*i;
            }
            return mas;
     }  
     
     void printMas(int[] masX)
    {
        for (int i = 0; i < masX.Length; i++)
            {
                Console.Write($"{masX[i]} ");
            }

    }