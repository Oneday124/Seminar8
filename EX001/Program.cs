// Задайте двумерный массив. Напишие программу, которая поменяет местами первую и последнюю строку массива.

int[,] FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(10);
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
        Console.WriteLine();
    }
}

int[,] ReplaceString (int[,] array, int cols, int rows)
{
    int temp = 0;
    for(int i = 0; i < cols; i++)
    {
        temp = array[0,i];
        array[0,i] = array[rows-1,i];
        array[rows-1,i] = temp;
    } 
    return array; 
}

int rows = 3;
int cols = 4;

int[,] array = new int[rows,cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

ReplaceString(array, cols, rows);
PrintArray(array);

