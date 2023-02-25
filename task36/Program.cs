// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// { 1, 2, 3, 4, 6, 1, 2, 1, 6}
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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
int[] rowArray = GetRowArray(array);
SortArray(rowArray);
PrintData(rowArray);

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

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i, j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length; j++)
        {
            if (inArray[i] < inArray[j])
            {
                int temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
}

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
}
