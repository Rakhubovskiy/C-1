// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты Xa: ");
double Xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Ya: ");
double Ya = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Xb: ");
double Xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координаты Yb: ");
double Yb = double.Parse(Console.ReadLine()!);
double AB = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya));
Console.WriteLine($"Расстояние между координатами {AB}");
