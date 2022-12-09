// Сформиуйте трехмерный массив из неповторяющихся двухзначных чисел, напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента

int[,,] FillArray(int[,,] array)
{
    int k = 0;
    while(k < array.GetLength(2))
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j,k] = new Random().Next(10,100);
            }
        }
        k++;
    }
    return array;
}

void PrintArray(int[,,] array)
{
    int k = 0;
    while(k < array.GetLength(2))
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
        k++;
    }
}

int rows = 2;
int cols = 2;
int h = 2;

int[,,] array = new int[rows,cols,h];
FillArray(array);
PrintArray(array);