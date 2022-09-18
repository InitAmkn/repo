/*  Задача 29: Напишите метод, который задаёт массив из 8 элементов 
(диапазон от 1 до 100) и выводит их на экран.
пример вывода
[1,4,5,3,1,2,3,9]
[4,45,53,31,14,25,63,19]
*/

// Добавил возможность выбирать кол-во элементов в массиве

class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите длину массива: ");
        int lengthMass = Convert.ToInt32(Console.ReadLine());

        randomMass(lengthMass);

        void randomMass(int lengthMass)
        {
            int[] outputMass = new int[lengthMass];
            for (int i = 0; i < lengthMass; i++)
            {
                outputMass[i] = new Random().Next(1, 100);

                Console.Write($"{outputMass[i]} ");
            }

        }
    }
}