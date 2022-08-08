//1. 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int randomThreeDigitNumber = new Random().Next(100,1000);
string stringNumber = Convert.ToString(randomThreeDigitNumber);
string stringNumberMini = "";
for (int i = 0;i<3;i++)
{
   if(i!=1)stringNumberMini = stringNumberMini + stringNumber[i];
}
Convert.ToInt32(stringNumberMini);

Console.WriteLine(randomThreeDigitNumber);
Console.WriteLine(stringNumberMini);