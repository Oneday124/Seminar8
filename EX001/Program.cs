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

int[,] ReplaceString (int[,] array, int rows)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == 0) 
            {
                temp = array[0,j];
                array[0,j] = array[rows-1,j];
                array[rows-1,j] = temp;
            }
        }
    }    
    return array;       
}

int rows = 3;
int cols = 4;

int[,] array = new int[rows,cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

ReplaceString(array, rows);
PrintArray(array);

