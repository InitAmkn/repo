/*
1. Написать метод, который генерирует массив 0 и 1 заданного количества N

3 -> 1 1 0
	 1 0 0
	 0 0 1
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число N");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] GenMas(int N)
        {

            int[] masRand = new int[N];

            for (int i = 0; i < N; i++)
            {
                masRand[i] = new Random().Next(0, 2);
            }
            return masRand;

        }

        for (int i = 0; i < N; i++)
        {
            Console.Write(GenMas(N)[i] + " ");
        }


    }
}



/*
2.Написать метод, принимающий бинарное представление числа
   и возвращающее десятиченое представление числа

1 1 0 0 -> 12
1 1 0 1 -> 13
*/

/*
3. Написать метод, принимающий  десятиченое представление
   и основание СС в которую нужно это число перевести
   2<= основание <= 9
10,2 -> 1010
10,8 -> 12
7,6 ->  10

*/
