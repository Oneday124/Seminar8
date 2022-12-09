// Задайте 2 матрицы, напишите программу, которая будет находить произведение 2х матриц

int[,] FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,5);
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

int[,] MultiplicationMatrix(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] array = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for(int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for(int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for(int k = 0; k < arrayTwo.GetLength(0); k++)
            {
                array[i,j] += arrayOne[i,k] * arrayTwo[k,j];
            }
        }
    }
    return array;
}

int rows = 2;
int cols = 2;

int[,] arrayOne = new int[rows,cols];
int[,] arrayTwo = new int[cols,rows];
FillArray(arrayOne);
PrintArray(arrayOne);
System.Console.WriteLine();
FillArray(arrayTwo);
PrintArray(arrayTwo);
System.Console.WriteLine();
if (arrayTwo.GetLength(1) != arrayOne.GetLength(0))
{
    Console.WriteLine("Matrixes can't be multiplied!!");
}
else PrintArray(MultiplicationMatrix(arrayOne, arrayTwo));