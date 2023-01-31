// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
int num1 = new Random().Next();
Console.WriteLine($"первое число {num1}");
int num2 = new Random().Next();
Console.WriteLine($"второе число {num2}");
int rem = num1 % num2;
if (rem == 0)
{
    Console.WriteLine($"{num1} кратно {num2}");
}
else
{
    Console.WriteLine($"{num1} не кратно {num2}, остаток деления {rem}");
}
