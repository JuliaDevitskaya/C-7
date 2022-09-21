// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
using System.Linq;
Clear();

WriteLine("Задайте размерность массива через пробел: ");
int[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
WriteLine();

int[,] matrix = GetArray(parametrs[0], parametrs[1]);
PrintArray(matrix);
WriteLine();

ArithmeticMean(matrix);

int[,] GetArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(1, 10);
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
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void ArithmeticMean(int[,] inArray)
{
    Write("Среднее арифмитическое каждого столбца: ");
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        Write($"{Math.Round(sum/inArray.GetLength(0),1)}; ");
    }
    WriteLine();
}
