/*
Задача 21
Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите координаты точки A через запятую");
        Console.WriteLine("пример ввода: 3,6,8");
         string? pointA = Console.ReadLine();
        Console.WriteLine("Введите координату B:");
         Console.WriteLine("пример ввода: 2,1,-7");
         string? pointB = Console.ReadLine();

        int [] masPointA = {};
        int [] masPointB = {};
        if(pointA != null)  masPointA = library.InputMas(pointA,',');
        if(pointB != null)  masPointB = library.InputMas(pointB,',');

        Console.WriteLine(distancePoints(masPointA,masPointB));

            double distancePoints(int[]pointA, int[]pointB)
            {
                double sumCoordinates = 0;
                for(int i=0; i < pointA.Count(); i++)
                {
                    sumCoordinates = sumCoordinates + (pointA[i]-pointB[i])*(pointA[i]-pointB[i]);
                }
                return Math.Sqrt(sumCoordinates);
            }
    }
  

}