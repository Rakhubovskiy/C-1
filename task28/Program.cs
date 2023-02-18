// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Clear();
int[] array = GetArray(10, 0, 9);
Console.WriteLine(string.Join(" ", array));
int[] cloneArray = CloneArray(array);
Console.WriteLine(string.Join(" ", cloneArray));

int[] GetArray(int length, int min, int max)
{
    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

int[] CloneArray(int[] someArray)
{
    int length = someArray.Length;
    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        res[i] = someArray[i];
    }
    return res;
}