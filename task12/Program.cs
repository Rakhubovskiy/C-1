// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер плоскости: ");
int plane = int.Parse(Console.ReadLine());

if (plane > 4 || plane < 0)
{
    Console.WriteLine("Такой плоскости нет");
}
else
{
    if (plane == 1)
    {
        Console.WriteLine("Координаты X > 0 , Y > 0");
    }
    else if (plane == 2)
    {
        Console.WriteLine("Координаты X < 0 , Y > 0");
    }
    else if (plane == 3)
    {
        Console.WriteLine("Координаты X < 0 , Y < 0");
    }
    else if (plane == 4)
    {
        Console.WriteLine("Координаты X > 0 , Y < 0");
    }
}