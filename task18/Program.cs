// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
//  Создать второй массив, и сложить с первым

Console.Clear();

int[] array1 = new int[8];
int[] array2 = new int[8];
int[] sumArray = new int[8];

FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
SumArray(sumArray);
PrintArray(sumArray);

void FillArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        Console.Write(array[index] + " ");
    }
}
void SumArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        array[index] = array1[index] + array2[index];
    }
}