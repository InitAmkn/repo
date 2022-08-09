
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int randomNumber = new Random().Next(100,1000);

Console.WriteLine(randomNumber);

Console.WriteLine(middleCharNumber(randomNumber));

int middleCharNumber(int threeDigitNumber)
{
    if(threeDigitNumber<100||threeDigitNumber>=1000)
   {
        Console.WriteLine("некорректный ввод");
       return 0;
    }

    int middleChar = threeDigitNumber % 100 /10;
    return middleChar;
}
