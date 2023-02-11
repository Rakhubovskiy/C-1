// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSumNums(num1)}");
Console.WriteLine($"Сумма чисел = {GetSumNums(num2)}");
Console.WriteLine($"Сумма чисел = {GetSumNums(num3)}");

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}