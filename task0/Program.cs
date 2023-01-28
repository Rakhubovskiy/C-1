// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();
Console.Write("Insert the number: ");
int number = int.Parse(Console.ReadLine()); // Переводим символный тип данных в числовой, с помощью int.Parse
int sqr = number * number;
Console.WriteLine("The square of the number " + number + " is " + sqr);
