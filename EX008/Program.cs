// Не решена. Напишите программу, которая спирально заполнит массив 4х4.

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

int[,] FillArray(int[,] array, int row, int col)
{
    int num = 10;
    int k = row;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == 0)
            {
                if(j != array.GetLength(1)-k)
                {
                    array[i, j] = num;
                    num++;
                }
                else
                {
                    while(i < array.GetLength(0))
                    {
                        array[array.GetLength(0)-k, j] = num;
                        num++;
                        i++;
                        k--;
                    }
                }
            }
        }
    }
    return array;
}

int rows = 4;
int cols = 4;

int[,] array = new int[rows,cols];

PrintArray(FillArray(array, rows, cols));