// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел = {GetProductNums(num1)}");
Console.WriteLine($"Сумма чисел = {GetProductNums(num2)}");

int GetProductNums(int number)
{
    int product = 1;
    for (product = 1; number > 0; number--)
    {
        product *= number;
    }
    return product;
}