// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
int[] array = new int[123];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(CountArray(array));

void FillArray(int[] fillArray)
{
    int length = fillArray.Length;
    for (int index = 0; index < length; index++)
    {
        fillArray[index] = new Random().Next(1, 123 + 1);
    }
}

void PrintArray(int[] printArray)
{
    int length = printArray.Length;
    for (int index = 0; index < length; index++)
    {
        Console.Write($"{printArray[index]} ");
    }
}

int CountArray(int[] countArray)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if ((array[index] >= 10) && (array[index] <= 99))
        {
            count++;
        }
    }
    return count;
}
