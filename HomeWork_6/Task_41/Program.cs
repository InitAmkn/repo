/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] InputMas(string matrix, char separator) //Считывание массива из строки
{
    string value = "";
    int[] mas = new int[matrix.Length];
    int j = 0;
    for (int i = 0; i < matrix.Length; i++)
    {

        if (matrix[i] != separator)
        {
            value = value + matrix[i];
        }
        if (matrix[i] == separator || i == matrix.Length - 1)
        {
            mas[j] = Convert.ToInt32(value);
            j++;
            value = "";
        }
    }

    return ResizeArray(mas, j);
}

int[] ResizeArray(int[] masInput, int count)//изменение размера массива
{
    int[] masOutput = new int[count];
    for (int i = 0; i < count; i++)
    {
        masOutput[i] = masInput[i];
    }
    return masOutput;
}

int[] numbers;
Console.WriteLine("Введите числа через запятую");
Console.WriteLine("пример ввода: 0,7,8,-2,-2");
numbers = InputMas(Console.ReadLine(), ',');
Console.WriteLine($"кол-во отрицательных чисел: {NegativeNumbersCounter(numbers)}");

int NegativeNumbersCounter(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < 0) count++;
    }
    return count;
}
