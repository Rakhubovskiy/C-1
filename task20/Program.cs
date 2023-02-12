// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


Console.Clear();
int[] array = GetArray(4, -8, 8);
Console.Write(" -> ");
ReplaceArray(array);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
void ReplaceArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            array[i] = array[i] * (-1);
            Console.Write(array[i] + " ");
        }
        else
        {
            array[i] = array[i] * (-1);
            Console.Write(array[i] + " ");
        }
    }
}