/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

using static System.Console;
using System.Linq;
Clear();

double[,] matrix=GetMatrixArray(3,4);
PrintMatrixArray(matrix);


double[,] GetMatrixArray (int rows, int colums)
{
    double[,] result= new double[rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i,j]=new Random().Next(-10,10)+ Math.Round(new Random().NextDouble(), 1);
        }
    }
    return result;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
    WriteLine(); 
    }
}



