// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
Console.Clear();


int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(GetSum(firstNum, secondNum));

int GetSum(int m, int n)
{
    if (m <= n) return (m + GetSum(m + 1, n));
    return 0;
}