// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();
int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ProductArray(array);

void FillArray(int[] fillArray)
{
    int length = fillArray.Length;
    for (int index = 0; index < length; index++)
    {
        fillArray[index] = new Random().Next(1, 10);
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

void ProductArray(int[] productArray)
{
    int length = productArray.Length;
    for (int index = 0; index <= length - 1; index++)
    {
        if (array[index] == array[length - 1])
        {
            Console.Write($"{array[index]} ");
        }
        else
        {
            array[index] = array[index] * array[length - 1];
            length--;
            Console.Write($"{array[index]} ");
        }
    }
}
