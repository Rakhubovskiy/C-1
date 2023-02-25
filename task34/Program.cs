// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.Write("Введите количество строк  массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцы  массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
// PrintArray(ChangeRowsColumns(array));
// Console.WriteLine();
SwitchFirstLastRow(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// int[,] ChangeRowsColumns(int[,] inArray)
// {
//     int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0) - 1; i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i != 0)
//             {
//                 newArray[i, j] = array[i, j];
//             }
//             else
//             {
//                 newArray[i, j] = array[array.GetLength(0) - 1, j];
//                 newArray[array.GetLength(0) - 1, j] = array[i, j];
//             }
//         }
//     }
//     return newArray;
// }

void SwitchFirstLastRow(int[,] inArray)
{
    int temp;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        temp = inArray[0, j];
        inArray[0, j] = inArray[inArray.GetLength(0) - 1, j];
        inArray[inArray.GetLength(0) - 1, j] = temp;
    }
}