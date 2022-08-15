
internal class Program
{

    private static void Main(string[] args)
    {
        /*
        1. Написать метод, который генерирует массив 0 и 1 заданного количества N

        3 -> 1 1 0
            1 0 0
            0 0 1
        */
        int[] GenMas(int N)
        {

            int[] masRand = new int[N];

            for (int i = 0; i < N; i++)
            {
                masRand[i] = new Random().Next(0, 2);
            }
            return masRand;

        }

        /*
        2.Написать метод, принимающий бинарное представление числа
           и возвращающее десятиченое представление числа

        1 1 0 0 -> 12
        1 1 0 1 -> 13
        */


        int conversionToDecimal(int[] mas)
        {
            int outNumber = 0;
            int power = 1;
            for (int i = mas.Length - 1; i >= 0; i--)
            {
                outNumber = outNumber + mas[i] * power;
                power = power * 2;
            }
            return outNumber;
        }

        /*
        3. Написать метод, принимающий  десятиченое представление
        и основание СС в которую нужно это число перевести
        2<= основание <= 9
        10,2 -> 1010
        10,8 -> 12
        7,6 ->  10
        */


        int[] numberConvert(int numInput, int Base)
        {

            int temp = numInput;
            int count = 0;
            while (temp != 0)
            {
                temp = temp / Base;
                count++;
            }
            int[] outMas = new int[count];
            while (numInput != 0)
            {
                outMas[count - 1] = numInput % Base;
                numInput = numInput / Base;
                count--;
            }

            return outMas;
        }


        //Console.WriteLine("Введите число N");
        //int N = Convert.ToInt32(Console.ReadLine());

        //int[] arr = GenMas(N);



        for (int i = 0; i < numberConvert(123, 8).Length; i++)
        {
            Console.Write(numberConvert(123, 8)[i] + " ");
        }

        //Console.WriteLine();
        // Console.WriteLine(conversionToDecimal(arr));









    }



}





