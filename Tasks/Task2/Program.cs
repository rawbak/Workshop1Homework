﻿// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
if (a<b)
{
Console.Write("max = " + b);
}
else
{
Console.Write("max = " + a);
}