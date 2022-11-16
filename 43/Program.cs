//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите число b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2");
double k2 = double.Parse(Console.ReadLine()!);
if (k1 != k2)
    {
        double y = (((b2 * k1) - (b1 * k2)) / (k1 - k2));
        if(k1 != 0)
        {
            double x = (y - b1) / k1;
            Console.WriteLine("координата x: " + x);
            Console.WriteLine("координата y: " + y);
        }
        else
        {
            double x = (y - b2) / k2;
            Console.WriteLine("координата x: " + x);
            Console.WriteLine("координата y: " + y);
        }
    }  
else
{   
    if(b1 != b2)
    {
        Console.WriteLine("Точек пересечения нет");
    }
    else
    {
        Console.WriteLine("Прямые совпадают(бесконечное количество точек пересечений");
    } 
}