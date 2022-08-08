internal class Program
{
    private static void Main(string[] args)
    {
        int maxChar(int value1, int value2)
        {
            int value3 = new Random().Next(value1,value2);
            int a = value3/10;
            int b = value3%10;
            int c = 0;
            if(a>b) c = a;
            if(a<b) c = b;
            
            
            Console.WriteLine(value3);
            return c;
        }

        Console.WriteLine(maxChar(10,100));


    }
}