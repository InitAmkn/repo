/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
using System;
internal class Program
{
    private static void Main(string[] args)
    {

        (double x, double y) FindIntersectionPoint(double k1, double b1, double k2, double b2)
        {
            double x, y;
            x = (b2 - b1) / (k1 - k2);
            y = k1 * (b2 - b1) / (k1 - k2) + b1;
            return (x, y);
        }


        Console.WriteLine(" y = k1 * x + b1  Введите значения k1 и b1");
        Console.Write("k1 = ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("b1 = ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" y = k2 * x + b2  Введите значения k2 и b2");
        Console.Write("k2 = ");
        double k2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("b2 = ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        double x = FindIntersectionPoint(k1, b1, k2, b2).x;
        double y = FindIntersectionPoint(k1, b1, k2, b2).y;

        Console.WriteLine($"точка пересечения: (x = {x}, y = {y})");
    }
}