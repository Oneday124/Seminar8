// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов 

int[,] FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
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

void SumOfRows (int[,] array)
{
    int minSumRows = 0;
    int row = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(minSumRows > sum || minSumRows == 0) 
        {
            minSumRows = sum;
            row = i+1;
        }
    }
    Console.WriteLine($"{row} строка");
}



int rows = 3;
int cols = 4;

int[,] array = new int[rows,cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SumOfRows(array);