// Составить частотный словарь элеменов двумерного массива
// Частотный словарь содержит информацию о том, сколько раз элемент встречается во входных данных

int[,] FillArray(int[,] array, int max)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(max);
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

int ItemCounts (int[,] array, int element)
{
    int count = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == element) count++;
        }
    } 
    return count; 
}

void PrintQuantity(int[,] array, int max)
{
    int element = 0;
    while(element <= max)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(ItemCounts(array, element) > 0) Console.WriteLine($"Элемент {element} встречается {ItemCounts(array, element)} раз");
                element++;
            }
        }
    }
}

int rows = 5;
int cols = 5;
int max = 20;

int[,] array = new int[rows,cols];

FillArray(array, max);
PrintArray(array);
System.Console.WriteLine();

PrintQuantity(array, max);