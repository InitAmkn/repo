//41. Выяснить являются ли три числа сторонами треугольника 
Console.WriteLine(IsTriangle(10, 6, 7));
bool IsTriangle(int length1, int length2, int length3)
{
    if (length1 + length2 > length3
     && length1 + length3 > length2
     && length2 + length3 > length1)
        return true;

    return false;
}

//42. Определить сколько чисел больше 0 введено с клавиатуры
