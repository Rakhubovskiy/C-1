// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
int[] array = GetArray(5, -3, 8);
int checkNum = 4;
if (CheckArray(array, checkNum))
{
    Console.WriteLine("Присутствует");

}
else
{
    Console.WriteLine("Отсутствует");
}

bool CheckArray(int[] array, int checkNum)
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == checkNum)
        {
            flag = true;
        }
    }
    return flag;
}

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
