// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write("Enter a three digit number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("The last digit in the number: ");
Console.WriteLine(number % 10);
