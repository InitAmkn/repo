//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int randomNumber = new Random().Next(0,10000);

 Console.WriteLine($"Random Number: {randomNumber}");
 Console.WriteLine($"Ver1: {threeCharNumberVer1(randomNumber)}");
 Console.WriteLine($"Ver2: {threeCharNumberVer2(randomNumber)}");

int threeCharNumberVer2 (int number)
{
    if(number >= 100)
    {
     while(number>1000)
        {
            number = number / 10;
        }
     return number%10;
    }
    else
        {
            Console.WriteLine("третьей цифры нет");
            return 0;
        }    
    }

string threeCharNumberVer1 (int number)
{
    string stringNumber = Convert.ToString(number);
    string thirdNumber ="";
   
   if(number >= 100)
    {
        thirdNumber = "" + stringNumber[2];  
        return thirdNumber;
     }
    else
    {
    return "третьей цифры нет";
    }
}


