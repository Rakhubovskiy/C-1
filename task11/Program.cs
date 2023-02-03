// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("ВВедите X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("ВВедите Y: ");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.WriteLine("Вы находитесь в первой плоскости");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("Вы находитесь во второй плоскости");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("Вы находитесь в третьей плоскости");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("Вы находитесь в четвертой плоскости");
}
if (X == 0 || Y == 0)
{
    Console.WriteLine("Вы не в плоскости");
}