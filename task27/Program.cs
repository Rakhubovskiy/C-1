﻿// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

int size = InPut();
int[] array = new int[size];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < size; i++)
{
    array[i] = array[i - 1] + array[i - 2];
}
Console.WriteLine(string.Join(" ", array));

int InPut()
{
    Console.Write("Введите число: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}