// Задайте двуменрный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int[,] FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    System.Console.WriteLine();
    }
}

int[,] SortArrayMin(int[,] array, int cols, int rows)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, k +1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;
}

int rows = 5;
int cols = 5;
int[,] array = new int[rows,cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

SortArrayMin(array, cols, rows);
PrintArray(array);