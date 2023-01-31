// Напишите программу, которая выводит на экран числа от 1 до 100.
// При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», а вместо чисел, кратных пяти — слово «Buzz».
// Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz».

Console.Clear();
int num = 1;
while (num <= 100)
{
    if ((num % 3 == 0) & (num % 5 == 0))
    {
        Console.WriteLine("FizzBuzz");
        num++;
    }
    if (num % 3 == 0)
    {
        Console.Write(" Fizz ");
        num++;
    }
    if (num % 5 == 0)
    {
        Console.Write(" Buzz ");
        num++;
    }
    else
    {
        Console.Write($" {num} ");
        num++;
    }
}