// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.
// M = 1; N = 5. -> "5, 4, 3, 2, 1"
// M = 4; N = 8. -> "8, 7, 6, 5, 4"

using System;
Console.Clear();

int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine();
GetNumbers(firstNum, secondNum);

void GetNumbers(int m, int n)
{
    if (n > m + 1)
    {
        Console.WriteLine($"{n - 1}");
        GetNumbers(m, n - 1);
    }
}