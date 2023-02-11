// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine($"В числе {num1} - {GetCount(num1)} цифры");
Console.WriteLine($"В числе {num2} - {GetCount(num2)} цифры");
Console.WriteLine($"В числе {num3} - {GetCount(num3)} цифр");

int GetCount(int number)
{
    int count = 0;
    for (count = 0; number > 0; count++)
    {
        number = number / 10;
    }
    return count;
}