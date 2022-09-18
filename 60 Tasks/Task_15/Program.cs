//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int randomNumber = new Random().Next(-20,20);

Console.WriteLine($"Random Number: {randomNumber}");
Console.WriteLine(IsItDayOff(randomNumber));

string IsItDayOff (int number)
{
    if(number >= 6 && number <= 7)
    {
        return "да";
    }
    else if(number > 7 ||number < 1)
    {
          return "некорректный ввод";
    }
    else
    {
        return "нет";
    } 
}