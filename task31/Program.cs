// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив             Новый массив будет
// выглядел вот так:                       выглядить вот так:
// 1 4 7 2                                 1 4 7 2
// 5 9 2 3                                 5 81 2 9
// 8 4 2 4                                 8 4 2 4

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
SqrArray(array);


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

void SqrArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{inArray[i, j] * inArray[i, j]} ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write($"{inArray[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}