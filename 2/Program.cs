/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите размеры массива через пробел: ");
int[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
WriteLine();

int[,] matrix = GetMatrixArray(parametrs[0], parametrs[1]);
PrintMatrixArray(matrix);
WriteLine();

WriteLine("Введите позицию элемента в массиве через пробел: ");
int[] position = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

FindElement(position, matrix);



int[,] GetMatrixArray(int rows, int colums)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintMatrixArray(int[,] inArray)
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

void FindElement(int[] coordinatesPosition, int[,] array)
{
    if (coordinatesPosition[0] < array.GetLength(0) && coordinatesPosition[1] < array.GetLength(1))
    {
        WriteLine($"Элемент найден: {array[coordinatesPosition[0], coordinatesPosition[1]]}");
    }
    else
    {
        WriteLine("Элемента с такой позицией нет. ");
    }
}



