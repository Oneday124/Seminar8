// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае если это невозможно
//программа должна вывести сообщение для пользователя

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

int[,] TranspositionArray (int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = i; j < array.GetLength(1); j++)
        {
            temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    } 
    return array; 
}

int rows = 4;
int cols = 4;

int[,] array = new int[rows,cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

if(rows != cols) System.Console.WriteLine("Невозможно транспонировать матрицу");
else
{
    TranspositionArray(array);
    PrintArray(array);
}



