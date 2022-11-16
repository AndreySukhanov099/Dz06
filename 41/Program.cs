//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int[] NewArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i =0; i < array.Length; i ++)
    {
        if(array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int number = int.Parse(Console.ReadLine()!);
if(number > 0)
{
    int[] array = new int[number];
    array = NewArray(array);
    Console.WriteLine("["+ string.Join(", ", array) +"]");
    Console.WriteLine("Число положительных чисел: " + PositiveNumbers(array));
}
else
Console.WriteLine("Неверный размер массива");